
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
      this.lblMidiDeviceName = new System.Windows.Forms.Label();
      this.txtMidiDeviceName = new System.Windows.Forms.TextBox();
      this.grpArduinoConnection.SuspendLayout();
      this.grpVirtualMIDI.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpArduinoConnection
      // 
      this.grpArduinoConnection.Controls.Add(this.lnkRefreshComPorts);
      this.grpArduinoConnection.Controls.Add(this.lblSerialBaud);
      this.grpArduinoConnection.Controls.Add(this.cmbSerialBaud);
      this.grpArduinoConnection.Controls.Add(this.lblSerialPort);
      this.grpArduinoConnection.Controls.Add(this.cmbSerialPort);
      this.grpArduinoConnection.Location = new System.Drawing.Point(16, 16);
      this.grpArduinoConnection.Name = "grpArduinoConnection";
      this.grpArduinoConnection.Size = new System.Drawing.Size(384, 104);
      this.grpArduinoConnection.TabIndex = 0;
      this.grpArduinoConnection.TabStop = false;
      this.grpArduinoConnection.Text = "Arduino connection";
      // 
      // lnkRefreshComPorts
      // 
      this.lnkRefreshComPorts.AutoSize = true;
      this.lnkRefreshComPorts.Location = new System.Drawing.Point(304, 40);
      this.lnkRefreshComPorts.Name = "lnkRefreshComPorts";
      this.lnkRefreshComPorts.Size = new System.Drawing.Size(66, 20);
      this.lnkRefreshComPorts.TabIndex = 8;
      this.lnkRefreshComPorts.TabStop = true;
      this.lnkRefreshComPorts.Text = "Refresh";
      this.lnkRefreshComPorts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshComPorts_LinkClicked);
      // 
      // lblSerialBaud
      // 
      this.lblSerialBaud.AutoSize = true;
      this.lblSerialBaud.Location = new System.Drawing.Point(16, 65);
      this.lblSerialBaud.Name = "lblSerialBaud";
      this.lblSerialBaud.Size = new System.Drawing.Size(47, 20);
      this.lblSerialBaud.TabIndex = 7;
      this.lblSerialBaud.Text = "Baud";
      // 
      // cmbSerialBaud
      // 
      this.cmbSerialBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialBaud.FormattingEnabled = true;
      this.cmbSerialBaud.Location = new System.Drawing.Point(112, 65);
      this.cmbSerialBaud.Name = "cmbSerialBaud";
      this.cmbSerialBaud.Size = new System.Drawing.Size(176, 28);
      this.cmbSerialBaud.TabIndex = 6;
      // 
      // lblSerialPort
      // 
      this.lblSerialPort.AutoSize = true;
      this.lblSerialPort.Location = new System.Drawing.Point(16, 32);
      this.lblSerialPort.Name = "lblSerialPort";
      this.lblSerialPort.Size = new System.Drawing.Size(81, 20);
      this.lblSerialPort.TabIndex = 5;
      this.lblSerialPort.Text = "Serial port";
      // 
      // cmbSerialPort
      // 
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(112, 32);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(176, 28);
      this.cmbSerialPort.TabIndex = 4;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(288, 368);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(152, 56);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lnkShowSettingsInFolder
      // 
      this.lnkShowSettingsInFolder.AutoSize = true;
      this.lnkShowSettingsInFolder.Location = new System.Drawing.Point(456, 392);
      this.lnkShowSettingsInFolder.Name = "lnkShowSettingsInFolder";
      this.lnkShowSettingsInFolder.Size = new System.Drawing.Size(109, 20);
      this.lnkShowSettingsInFolder.TabIndex = 9;
      this.lnkShowSettingsInFolder.TabStop = true;
      this.lnkShowSettingsInFolder.Text = "Show in folder";
      this.lnkShowSettingsInFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowSettingsInFolder_LinkClicked);
      // 
      // grpVirtualMIDI
      // 
      this.grpVirtualMIDI.Controls.Add(this.txtMidiDeviceName);
      this.grpVirtualMIDI.Controls.Add(this.lblMidiDeviceName);
      this.grpVirtualMIDI.Location = new System.Drawing.Point(8, 128);
      this.grpVirtualMIDI.Name = "grpVirtualMIDI";
      this.grpVirtualMIDI.Size = new System.Drawing.Size(400, 160);
      this.grpVirtualMIDI.TabIndex = 10;
      this.grpVirtualMIDI.TabStop = false;
      this.grpVirtualMIDI.Text = "Virtual MIDI";
      // 
      // lblMidiDeviceName
      // 
      this.lblMidiDeviceName.AutoSize = true;
      this.lblMidiDeviceName.Location = new System.Drawing.Point(24, 32);
      this.lblMidiDeviceName.Name = "lblMidiDeviceName";
      this.lblMidiDeviceName.Size = new System.Drawing.Size(101, 20);
      this.lblMidiDeviceName.TabIndex = 6;
      this.lblMidiDeviceName.Text = "Device name";
      // 
      // txtMidiDeviceName
      // 
      this.txtMidiDeviceName.Location = new System.Drawing.Point(144, 32);
      this.txtMidiDeviceName.Name = "txtMidiDeviceName";
      this.txtMidiDeviceName.Size = new System.Drawing.Size(208, 26);
      this.txtMidiDeviceName.TabIndex = 7;
      // 
      // frmSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.grpVirtualMIDI);
      this.Controls.Add(this.lnkShowSettingsInFolder);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.grpArduinoConnection);
      this.Name = "frmSettings";
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.frmSettings_Load);
      this.grpArduinoConnection.ResumeLayout(false);
      this.grpArduinoConnection.PerformLayout();
      this.grpVirtualMIDI.ResumeLayout(false);
      this.grpVirtualMIDI.PerformLayout();
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
  }
}