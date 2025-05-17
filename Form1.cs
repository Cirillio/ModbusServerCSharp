using NModbus;
using NModbus.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System;
using System.Windows.Forms;

namespace ModbusServer
{
    public partial class Form1 : Form
    {
        private Button sendButton;
        private Label connectionStatus;
        private TableLayoutPanel rootPanel;
        private Panel header;
        private Label headerLabel;
        private TableLayoutPanel mainPanel;
        private TableLayoutPanel leftPanel;
        private Label connLabel;

        private TextBox portTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button okButton;
        private TextBox ipTextBox;
        private Button connectButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label connectionStatusLabel;
        private ListBox errorListBox;
        private Button buttonClearLogs;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel inputPanel;
        private TextBox messageBox;
        private Panel panel1;
        private ListBox chatBox;
        private Button clearButton;

        private TcpListener tcpListener;
        private IModbusSlaveNetwork slaveNetwork;
        private ISlaveDataStore dataStore;
        private Thread listenThread, sendThread;
        private volatile bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
            InitHandlers();
        }

        private void InitHandlers()
        {
            connectButton.Click += (s, e) => ToggleServer();
            clearButton.Click += new EventHandler((s, e) => { ipTextBox.Text = ""; portTextBox.Text = ""; });
            okButton.Click += new EventHandler((s, e) => ToggleServer());
            messageBox.KeyDown += MessageBox_KeyDown;
            sendButton.Click += (s, e) => SendMessage();
            buttonClearLogs.Click += (s, e) => errorListBox.Items.Clear();
        }

        private void ToggleServer()
        {
            if (isRunning)
            {
                isRunning = false;
                Thread.Sleep(200);
                tcpListener.Stop();
                connectionStatus.Text = "Stopped";
                connectButton.Text = "Start";
                connectionStatus.BackColor = Color.DarkGray;
                connectionStatus.ForeColor = Color.Black;

            }
            else
            {
                try
                {
                    int port = int.Parse(portTextBox.Text);
                    IPAddress iPAddress = IPAddress.Parse(ipTextBox.Text);
                    tcpListener = new TcpListener(iPAddress, port);
                    tcpListener.Start();

                    var factory = new ModbusFactory();
                    dataStore = new DefaultSlaveDataStore();
                    var slave = factory.CreateSlave(1, dataStore);
                    slaveNetwork = factory.CreateSlaveNetwork(tcpListener);
                    slaveNetwork.AddSlave(slave);
                    _ = slaveNetwork.ListenAsync();

                    isRunning = true;
                    listenThread = new Thread(() => ListenLoop());
                    listenThread.IsBackground = true;
                    listenThread.Start();

                    connectionStatus.Text = "Listening";
                    connectButton.Text = "Stop";

                    connectionStatus.ForeColor = Color.White;
                    connectionStatus.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    errorListBox.Items.Add("[ERROR] " + ex.Message);
                    connectionStatus.Text = "Error";
                    connectionStatus.BackColor = Color.Red;
                    connectionStatus.ForeColor = Color.White;

                }
            }
        }

        private void ListenLoop()
        {
            while (isRunning)
            {
                try
                {
                    if (dataStore.HoldingRegisters.ReadPoints(100, 1)[0] == 1)
                    {
                        ushort[] buf = dataStore.HoldingRegisters.ReadPoints(0, 50);
                        string msg = Decode(buf);
                        if (!string.IsNullOrWhiteSpace(msg))
                        {
                            Invoke((MethodInvoker)(() =>
                            {
                                chatBox.Items.Add("[Client " + DateTime.Now.ToLongTimeString() + "]: " + msg);
                            }));
                            dataStore.HoldingRegisters.WritePoints(0, new ushort[50]);
                            dataStore.HoldingRegisters.WritePoints(100, new ushort[] { 0 });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Invoke((MethodInvoker)(() => errorListBox.Items.Add("[Listen ERROR] " + ex.Message)));
                }
                Thread.Sleep(100);
            }
        }

        private void SendMessage()
        {
            if (!isRunning || dataStore == null) return;

            string msg = messageBox.Text;
            ushort[] payload = Encode(msg);
            dataStore.HoldingRegisters.WritePoints(200, payload);
            dataStore.HoldingRegisters.WritePoints(300, new ushort[] { 1 });

            chatBox.Items.Add("[Server " + DateTime.Now.ToLongTimeString() + "]: " + msg);
            messageBox.Clear();


            Thread.Sleep(100);
            dataStore.HoldingRegisters.WritePoints(300, new ushort[] { 0 });
        }


        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }

        private static ushort[] Encode(string message)
        {
            var bytes = Encoding.ASCII.GetBytes(message);
            int len = (bytes.Length + 1) / 2;
            var result = new ushort[len];
            for (int i = 0; i < bytes.Length; i++)
            {
                int index = i / 2;
                if (i % 2 == 0)
                    result[index] = bytes[i];
                else
                    result[index] |= (ushort)(bytes[i] << 8);
            }
            return result;
        }

        private static string Decode(ushort[] data)
        {
            byte[] bytes = new byte[data.Length * 2];
            for (int i = 0; i < data.Length; i++)
            {
                bytes[i * 2] = (byte)(data[i] & 0xFF);
                bytes[i * 2 + 1] = (byte)(data[i] >> 8);
            }
            return Encoding.ASCII.GetString(bytes).TrimEnd('\0');
        }

    }
}
