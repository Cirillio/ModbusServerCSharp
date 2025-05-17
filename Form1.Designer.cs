namespace ModbusServer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rootPanel = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.connLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.errorListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.inputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.buttonClearChat = new System.Windows.Forms.Button();
            this.buttonClearLogs = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rootPanel.SuspendLayout();
            this.header.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rootPanel.ColumnCount = 1;
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootPanel.Controls.Add(this.header, 0, 0);
            this.rootPanel.Controls.Add(this.mainPanel, 0, 1);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.RowCount = 2;
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootPanel.Size = new System.Drawing.Size(944, 501);
            this.rootPanel.TabIndex = 0;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.header.Controls.Add(this.headerLabel);
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Location = new System.Drawing.Point(3, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(938, 54);
            this.header.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headerLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.headerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerLabel.Location = new System.Drawing.Point(49, -3);
            this.headerLabel.MaximumSize = new System.Drawing.Size(840, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(10);
            this.headerLabel.Size = new System.Drawing.Size(840, 60);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Modbus Server";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.leftPanel, 0, 0);
            this.mainPanel.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.mainPanel.Location = new System.Drawing.Point(52, 63);
            this.mainPanel.MaximumSize = new System.Drawing.Size(840, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(840, 435);
            this.mainPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.leftPanel.AutoSize = true;
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.leftPanel.Controls.Add(this.ipTextBox, 0, 1);
            this.leftPanel.Controls.Add(this.portTextBox, 0, 2);
            this.leftPanel.Controls.Add(this.connLabel, 0, 0);
            this.leftPanel.Controls.Add(this.connectButton, 0, 3);
            this.leftPanel.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.leftPanel.Controls.Add(this.errorListBox, 0, 5);
            this.leftPanel.Location = new System.Drawing.Point(3, 95);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.RowCount = 6;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftPanel.Size = new System.Drawing.Size(181, 337);
            this.leftPanel.TabIndex = 0;
            // 
            // ipTextBox
            // 
            this.ipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ipTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipTextBox.Enabled = false;
            this.ipTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipTextBox.Location = new System.Drawing.Point(16, 48);
            this.ipTextBox.MaxLength = 16;
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.ReadOnly = true;
            this.ipTextBox.Size = new System.Drawing.Size(149, 27);
            this.ipTextBox.TabIndex = 4;
            this.ipTextBox.Text = "Any";
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portTextBox
            // 
            this.portTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portTextBox.Location = new System.Drawing.Point(16, 84);
            this.portTextBox.MaxLength = 5;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(149, 27);
            this.portTextBox.TabIndex = 2;
            this.portTextBox.Text = "502";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connLabel
            // 
            this.connLabel.AutoSize = true;
            this.connLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.connLabel.Location = new System.Drawing.Point(16, 13);
            this.connLabel.Name = "connLabel";
            this.connLabel.Size = new System.Drawing.Size(149, 29);
            this.connLabel.TabIndex = 0;
            this.connLabel.Text = "Connection";
            this.connLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectButton.AutoSize = true;
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.connectButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.Location = new System.Drawing.Point(51, 120);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(79, 40);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Start";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.connectionStatus, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.connectionStatusLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 176);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(135, 20);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // connectionStatus
            // 
            this.connectionStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.BackColor = System.Drawing.Color.Silver;
            this.connectionStatus.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionStatus.Location = new System.Drawing.Point(68, 1);
            this.connectionStatus.Margin = new System.Windows.Forms.Padding(0);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(52, 17);
            this.connectionStatus.TabIndex = 1;
            this.connectionStatus.Text = "Stopped";
            this.connectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.connectionStatusLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionStatusLabel.Location = new System.Drawing.Point(3, 0);
            this.connectionStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(47, 19);
            this.connectionStatusLabel.TabIndex = 0;
            this.connectionStatusLabel.Text = "Status:";
            this.connectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorListBox
            // 
            this.errorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorListBox.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorListBox.FormattingEnabled = true;
            this.errorListBox.HorizontalScrollbar = true;
            this.errorListBox.IntegralHeight = false;
            this.errorListBox.Location = new System.Drawing.Point(16, 212);
            this.errorListBox.MaximumSize = new System.Drawing.Size(0, 180);
            this.errorListBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.errorListBox.Name = "errorListBox";
            this.errorListBox.Size = new System.Drawing.Size(149, 60);
            this.errorListBox.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.inputPanel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(190, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(647, 429);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputPanel.ColumnCount = 2;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.inputPanel.Controls.Add(this.sendButton, 1, 0);
            this.inputPanel.Controls.Add(this.messageBox, 0, 0);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(3, 362);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 1;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.Size = new System.Drawing.Size(641, 64);
            this.inputPanel.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sendButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(551, 7);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(80, 50);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageBox.Location = new System.Drawing.Point(10, 3);
            this.messageBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.messageBox.MaxLength = 240;
            this.messageBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(521, 60);
            this.messageBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chatBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(641, 353);
            this.panel1.TabIndex = 1;
            // 
            // chatBox
            // 
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatBox.FormattingEnabled = true;
            this.chatBox.HorizontalScrollbar = true;
            this.chatBox.ItemHeight = 19;
            this.chatBox.Location = new System.Drawing.Point(10, 10);
            this.chatBox.Margin = new System.Windows.Forms.Padding(10);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(617, 329);
            this.chatBox.TabIndex = 0;
            // 
            // buttonClearChat
            // 
            this.buttonClearChat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearChat.AutoSize = true;
            this.buttonClearChat.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClearChat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearChat.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearChat.Location = new System.Drawing.Point(81, 7);
            this.buttonClearChat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearChat.MaximumSize = new System.Drawing.Size(60, 32);
            this.buttonClearChat.MinimumSize = new System.Drawing.Size(60, 0);
            this.buttonClearChat.Name = "buttonClearChat";
            this.buttonClearChat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonClearChat.Size = new System.Drawing.Size(60, 26);
            this.buttonClearChat.TabIndex = 9;
            this.buttonClearChat.Text = "ChatCl";
            this.buttonClearChat.UseVisualStyleBackColor = true;
            // 
            // buttonClearLogs
            // 
            this.buttonClearLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearLogs.AutoSize = true;
            this.buttonClearLogs.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClearLogs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearLogs.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearLogs.Location = new System.Drawing.Point(7, 7);
            this.buttonClearLogs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearLogs.MaximumSize = new System.Drawing.Size(60, 32);
            this.buttonClearLogs.MinimumSize = new System.Drawing.Size(60, 0);
            this.buttonClearLogs.Name = "buttonClearLogs";
            this.buttonClearLogs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonClearLogs.Size = new System.Drawing.Size(60, 26);
            this.buttonClearLogs.TabIndex = 8;
            this.buttonClearLogs.Text = "LogsCl";
            this.buttonClearLogs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonClearChat, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonClearLogs, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(16, 281);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(149, 40);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.rootPanel);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Form1";
            this.Text = "Modbus client";
            this.rootPanel.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonClearChat;
        private System.Windows.Forms.Button buttonClearLogs;
    }
}

