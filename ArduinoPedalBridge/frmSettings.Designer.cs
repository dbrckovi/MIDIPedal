
namespace ArduinoPedalBridge
{
  partial class frmSettings
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.grpArduinoConnection = new System.Windows.Forms.GroupBox();
      this.lnkRefreshComPorts = new System.Windows.Forms.LinkLabel();
      this.lblSerialBaud = new System.Windows.Forms.Label();
      this.cmbSerialBaud = new System.Windows.Forms.ComboBox();
      this.lblSerialPort = new System.Windows.Forms.Label();
      this.cmbSerialPort = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.lnkShowSettingsInFolder = new System.Windows.Forms.LinkLabel();
      this.grpVirtualMIDI = new System.Windows.Forms.GroupBox();
      this.txtMidiDeviceName = new System.Windows.Forms.TextBox();
      this.lblMidiDeviceName = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnDeleteEvent = new System.Windows.Forms.Button();
      this.btnEditEvent = new System.Windows.Forms.Button();
      this.btnAddEvent = new System.Windows.Forms.Button();
      this.dataButtonEvents = new System.Windows.Forms.DataGridView();
      this.colButtonIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colButtonPressed = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMessageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.chkButtonTogglable1 = new System.Windows.Forms.CheckBox();
      this.chkButtonTogglable2 = new System.Windows.Forms.CheckBox();
      this.chkButtonTogglable3 = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.grpArduinoConnection.SuspendLayout();
      this.grpVirtualMIDI.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataButtonEvents)).BeginInit();
      this.SuspendLayout();
      // 
      // grpArduinoConnection
      // 
      this.grpArduinoConnection.Controls.Add(this.label1);
      this.grpArduinoConnection.Controls.Add(this.chkButtonTogglable3);
      this.grpArduinoConnection.Controls.Add(this.chkButtonTogglable2);
      this.grpArduinoConnection.Controls.Add(this.chkButtonTogglable1);
      this.grpArduinoConnection.Controls.Add(this.lnkRefreshComPorts);
      this.grpArduinoConnection.Controls.Add(this.lblSerialBaud);
      this.grpArduinoConnection.Controls.Add(this.cmbSerialBaud);
      this.grpArduinoConnection.Controls.Add(this.lblSerialPort);
      this.grpArduinoConnection.Controls.Add(this.cmbSerialPort);
      this.grpArduinoConnection.Location = new System.Drawing.Point(8, 8);
      this.grpArduinoConnection.Margin = new System.Windows.Forms.Padding(2);
      this.grpArduinoConnection.Name = "grpArduinoConnection";
      this.grpArduinoConnection.Padding = new System.Windows.Forms.Padding(2);
      this.grpArduinoConnection.Size = new System.Drawing.Size(256, 136);
      this.grpArduinoConnection.TabIndex = 0;
      this.grpArduinoConnection.TabStop = false;
      this.grpArduinoConnection.Text = "Arduino connection";
      // 
      // lnkRefreshComPorts
      // 
      this.lnkRefreshComPorts.AutoSize = true;
      this.lnkRefreshComPorts.Location = new System.Drawing.Point(203, 26);
      this.lnkRefreshComPorts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lnkRefreshComPorts.Name = "lnkRefreshComPorts";
      this.lnkRefreshComPorts.Size = new System.Drawing.Size(44, 13);
      this.lnkRefreshComPorts.TabIndex = 8;
      this.lnkRefreshComPorts.TabStop = true;
      this.lnkRefreshComPorts.Text = "Refresh";
      this.lnkRefreshComPorts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshComPorts_LinkClicked);
      // 
      // lblSerialBaud
      // 
      this.lblSerialBaud.AutoSize = true;
      this.lblSerialBaud.Location = new System.Drawing.Point(8, 40);
      this.lblSerialBaud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSerialBaud.Name = "lblSerialBaud";
      this.lblSerialBaud.Size = new System.Drawing.Size(32, 13);
      this.lblSerialBaud.TabIndex = 7;
      this.lblSerialBaud.Text = "Baud";
      // 
      // cmbSerialBaud
      // 
      this.cmbSerialBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialBaud.FormattingEnabled = true;
      this.cmbSerialBaud.Location = new System.Drawing.Point(72, 40);
      this.cmbSerialBaud.Margin = new System.Windows.Forms.Padding(2);
      this.cmbSerialBaud.Name = "cmbSerialBaud";
      this.cmbSerialBaud.Size = new System.Drawing.Size(119, 21);
      this.cmbSerialBaud.TabIndex = 6;
      // 
      // lblSerialPort
      // 
      this.lblSerialPort.AutoSize = true;
      this.lblSerialPort.Location = new System.Drawing.Point(8, 16);
      this.lblSerialPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSerialPort.Name = "lblSerialPort";
      this.lblSerialPort.Size = new System.Drawing.Size(54, 13);
      this.lblSerialPort.TabIndex = 5;
      this.lblSerialPort.Text = "Serial port";
      // 
      // cmbSerialPort
      // 
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(72, 16);
      this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(2);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(119, 21);
      this.cmbSerialPort.TabIndex = 4;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(184, 432);
      this.btnSave.Margin = new System.Windows.Forms.Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(101, 36);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lnkShowSettingsInFolder
      // 
      this.lnkShowSettingsInFolder.AutoSize = true;
      this.lnkShowSettingsInFolder.Location = new System.Drawing.Point(296, 448);
      this.lnkShowSettingsInFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lnkShowSettingsInFolder.Name = "lnkShowSettingsInFolder";
      this.lnkShowSettingsInFolder.Size = new System.Drawing.Size(74, 13);
      this.lnkShowSettingsInFolder.TabIndex = 9;
      this.lnkShowSettingsInFolder.TabStop = true;
      this.lnkShowSettingsInFolder.Text = "Show in folder";
      this.lnkShowSettingsInFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowSettingsInFolder_LinkClicked);
      // 
      // grpVirtualMIDI
      // 
      this.grpVirtualMIDI.Controls.Add(this.txtMidiDeviceName);
      this.grpVirtualMIDI.Controls.Add(this.lblMidiDeviceName);
      this.grpVirtualMIDI.Location = new System.Drawing.Point(8, 152);
      this.grpVirtualMIDI.Margin = new System.Windows.Forms.Padding(2);
      this.grpVirtualMIDI.Name = "grpVirtualMIDI";
      this.grpVirtualMIDI.Padding = new System.Windows.Forms.Padding(2);
      this.grpVirtualMIDI.Size = new System.Drawing.Size(256, 48);
      this.grpVirtualMIDI.TabIndex = 10;
      this.grpVirtualMIDI.TabStop = false;
      this.grpVirtualMIDI.Text = "Virtual MIDI";
      // 
      // txtMidiDeviceName
      // 
      this.txtMidiDeviceName.Location = new System.Drawing.Point(96, 16);
      this.txtMidiDeviceName.Margin = new System.Windows.Forms.Padding(2);
      this.txtMidiDeviceName.MaxLength = 64;
      this.txtMidiDeviceName.Name = "txtMidiDeviceName";
      this.txtMidiDeviceName.Size = new System.Drawing.Size(152, 20);
      this.txtMidiDeviceName.TabIndex = 7;
      // 
      // lblMidiDeviceName
      // 
      this.lblMidiDeviceName.AutoSize = true;
      this.lblMidiDeviceName.Location = new System.Drawing.Point(16, 16);
      this.lblMidiDeviceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblMidiDeviceName.Name = "lblMidiDeviceName";
      this.lblMidiDeviceName.Size = new System.Drawing.Size(70, 13);
      this.lblMidiDeviceName.TabIndex = 6;
      this.lblMidiDeviceName.Text = "Device name";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnDeleteEvent);
      this.groupBox1.Controls.Add(this.btnEditEvent);
      this.groupBox1.Controls.Add(this.btnAddEvent);
      this.groupBox1.Controls.Add(this.dataButtonEvents);
      this.groupBox1.Location = new System.Drawing.Point(272, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(480, 240);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Button events";
      // 
      // btnDeleteEvent
      // 
      this.btnDeleteEvent.Enabled = false;
      this.btnDeleteEvent.Location = new System.Drawing.Point(104, 16);
      this.btnDeleteEvent.Name = "btnDeleteEvent";
      this.btnDeleteEvent.Size = new System.Drawing.Size(48, 24);
      this.btnDeleteEvent.TabIndex = 3;
      this.btnDeleteEvent.Text = "Delete";
      this.btnDeleteEvent.UseVisualStyleBackColor = true;
      this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
      // 
      // btnEditEvent
      // 
      this.btnEditEvent.Enabled = false;
      this.btnEditEvent.Location = new System.Drawing.Point(56, 16);
      this.btnEditEvent.Name = "btnEditEvent";
      this.btnEditEvent.Size = new System.Drawing.Size(40, 24);
      this.btnEditEvent.TabIndex = 2;
      this.btnEditEvent.Text = "Edit";
      this.btnEditEvent.UseVisualStyleBackColor = true;
      this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
      // 
      // btnAddEvent
      // 
      this.btnAddEvent.Location = new System.Drawing.Point(8, 16);
      this.btnAddEvent.Name = "btnAddEvent";
      this.btnAddEvent.Size = new System.Drawing.Size(40, 24);
      this.btnAddEvent.TabIndex = 1;
      this.btnAddEvent.Text = "Add";
      this.btnAddEvent.UseVisualStyleBackColor = true;
      this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
      // 
      // dataButtonEvents
      // 
      this.dataButtonEvents.AllowUserToAddRows = false;
      this.dataButtonEvents.AllowUserToDeleteRows = false;
      this.dataButtonEvents.AllowUserToResizeColumns = false;
      this.dataButtonEvents.AllowUserToResizeRows = false;
      this.dataButtonEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataButtonEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataButtonEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colButtonIndex,
            this.colButtonPressed,
            this.colChannel,
            this.colMessageType,
            this.colNote,
            this.colVolume});
      this.dataButtonEvents.Location = new System.Drawing.Point(8, 48);
      this.dataButtonEvents.MultiSelect = false;
      this.dataButtonEvents.Name = "dataButtonEvents";
      this.dataButtonEvents.RowHeadersVisible = false;
      this.dataButtonEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataButtonEvents.Size = new System.Drawing.Size(464, 184);
      this.dataButtonEvents.TabIndex = 0;
      this.dataButtonEvents.SelectionChanged += new System.EventHandler(this.dataButtonEvents_SelectionChanged);
      this.dataButtonEvents.DoubleClick += new System.EventHandler(this.dataButtonEvents_DoubleClick);
      this.dataButtonEvents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataButtonEvents_KeyUp);
      // 
      // colButtonIndex
      // 
      this.colButtonIndex.DataPropertyName = "ButtonIndex";
      this.colButtonIndex.HeaderText = "Button";
      this.colButtonIndex.Name = "colButtonIndex";
      this.colButtonIndex.ReadOnly = true;
      this.colButtonIndex.Width = 63;
      // 
      // colButtonPressed
      // 
      this.colButtonPressed.DataPropertyName = "ButtonPressed";
      this.colButtonPressed.HeaderText = "ButtonPressed";
      this.colButtonPressed.Name = "colButtonPressed";
      this.colButtonPressed.ReadOnly = true;
      this.colButtonPressed.Width = 101;
      // 
      // colChannel
      // 
      this.colChannel.DataPropertyName = "Channel";
      this.colChannel.HeaderText = "Channel";
      this.colChannel.Name = "colChannel";
      this.colChannel.ReadOnly = true;
      this.colChannel.Width = 71;
      // 
      // colMessageType
      // 
      this.colMessageType.DataPropertyName = "MessageType";
      this.colMessageType.HeaderText = "MessageType";
      this.colMessageType.Name = "colMessageType";
      this.colMessageType.ReadOnly = true;
      this.colMessageType.Width = 99;
      // 
      // colNote
      // 
      this.colNote.DataPropertyName = "Note";
      this.colNote.HeaderText = "Note";
      this.colNote.Name = "colNote";
      this.colNote.ReadOnly = true;
      this.colNote.Width = 55;
      // 
      // colVolume
      // 
      this.colVolume.DataPropertyName = "Volume";
      this.colVolume.HeaderText = "Volume";
      this.colVolume.Name = "colVolume";
      this.colVolume.ReadOnly = true;
      this.colVolume.Width = 67;
      // 
      // chkButtonTogglable1
      // 
      this.chkButtonTogglable1.AutoSize = true;
      this.chkButtonTogglable1.Location = new System.Drawing.Point(72, 72);
      this.chkButtonTogglable1.Name = "chkButtonTogglable1";
      this.chkButtonTogglable1.Size = new System.Drawing.Size(66, 17);
      this.chkButtonTogglable1.TabIndex = 9;
      this.chkButtonTogglable1.Text = "Button 0";
      this.chkButtonTogglable1.UseVisualStyleBackColor = true;
      // 
      // chkButtonTogglable2
      // 
      this.chkButtonTogglable2.AutoSize = true;
      this.chkButtonTogglable2.Location = new System.Drawing.Point(72, 88);
      this.chkButtonTogglable2.Name = "chkButtonTogglable2";
      this.chkButtonTogglable2.Size = new System.Drawing.Size(66, 17);
      this.chkButtonTogglable2.TabIndex = 10;
      this.chkButtonTogglable2.Text = "Button 1";
      this.chkButtonTogglable2.UseVisualStyleBackColor = true;
      // 
      // chkButtonTogglable3
      // 
      this.chkButtonTogglable3.AutoSize = true;
      this.chkButtonTogglable3.Location = new System.Drawing.Point(72, 104);
      this.chkButtonTogglable3.Name = "chkButtonTogglable3";
      this.chkButtonTogglable3.Size = new System.Drawing.Size(66, 17);
      this.chkButtonTogglable3.TabIndex = 11;
      this.chkButtonTogglable3.Text = "Button 2";
      this.chkButtonTogglable3.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 72);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 12;
      this.label1.Text = "Togglable";
      // 
      // frmSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(765, 496);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.grpVirtualMIDI);
      this.Controls.Add(this.lnkShowSettingsInFolder);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.grpArduinoConnection);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "frmSettings";
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.frmSettings_Load);
      this.grpArduinoConnection.ResumeLayout(false);
      this.grpArduinoConnection.PerformLayout();
      this.grpVirtualMIDI.ResumeLayout(false);
      this.grpVirtualMIDI.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataButtonEvents)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox grpArduinoConnection;
    private System.Windows.Forms.Label lblSerialBaud;
    private System.Windows.Forms.ComboBox cmbSerialBaud;
    private System.Windows.Forms.Label lblSerialPort;
    private System.Windows.Forms.ComboBox cmbSerialPort;
    private System.Windows.Forms.LinkLabel lnkRefreshComPorts;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.LinkLabel lnkShowSettingsInFolder;
    private System.Windows.Forms.GroupBox grpVirtualMIDI;
    private System.Windows.Forms.Label lblMidiDeviceName;
    private System.Windows.Forms.TextBox txtMidiDeviceName;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dataButtonEvents;
    private System.Windows.Forms.DataGridViewTextBoxColumn colButtonIndex;
    private System.Windows.Forms.DataGridViewTextBoxColumn colButtonPressed;
    private System.Windows.Forms.DataGridViewTextBoxColumn colChannel;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMessageType;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    private System.Windows.Forms.DataGridViewTextBoxColumn colVolume;
    private System.Windows.Forms.Button btnDeleteEvent;
    private System.Windows.Forms.Button btnEditEvent;
    private System.Windows.Forms.Button btnAddEvent;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox chkButtonTogglable3;
    private System.Windows.Forms.CheckBox chkButtonTogglable2;
    private System.Windows.Forms.CheckBox chkButtonTogglable1;
  }
}