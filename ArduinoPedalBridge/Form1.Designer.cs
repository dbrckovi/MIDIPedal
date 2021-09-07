
namespace ArduinoPedalBridge
{
  partial class Form1
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
      this.btnArduinoPing = new System.Windows.Forms.Button();
      this.buttonState3 = new ArduinoPedalBridge.ButtonState();
      this.buttonState2 = new ArduinoPedalBridge.ButtonState();
      this.buttonState1 = new ArduinoPedalBridge.ButtonState();
      this.pedalValue = new ArduinoPedalBridge.PotVisualizer();
      this.txtArduinoConnectionBaud = new System.Windows.Forms.Label();
      this.txtArduinoConnectionPort = new System.Windows.Forms.Label();
      this.lblArduinoConnectionBaud = new System.Windows.Forms.Label();
      this.lblArduinoConnectionPort = new System.Windows.Forms.Label();
      this.txtArduinoConnectionStatus = new System.Windows.Forms.Label();
      this.lblArduinoConnectionStatus = new System.Windows.Forms.Label();
      this.btnSettings = new System.Windows.Forms.Button();
      this.grpMIDIDevice = new System.Windows.Forms.GroupBox();
      this.txtMIDIDeviceName = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.grpArduinoConnection.SuspendLayout();
      this.grpMIDIDevice.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpArduinoConnection
      // 
      this.grpArduinoConnection.Controls.Add(this.btnArduinoPing);
      this.grpArduinoConnection.Controls.Add(this.buttonState3);
      this.grpArduinoConnection.Controls.Add(this.buttonState2);
      this.grpArduinoConnection.Controls.Add(this.buttonState1);
      this.grpArduinoConnection.Controls.Add(this.pedalValue);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionBaud);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionPort);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionBaud);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionPort);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionStatus);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionStatus);
      this.grpArduinoConnection.Location = new System.Drawing.Point(8, 32);
      this.grpArduinoConnection.Name = "grpArduinoConnection";
      this.grpArduinoConnection.Size = new System.Drawing.Size(368, 112);
      this.grpArduinoConnection.TabIndex = 5;
      this.grpArduinoConnection.TabStop = false;
      this.grpArduinoConnection.Text = "Arduino connection";
      // 
      // btnArduinoPing
      // 
      this.btnArduinoPing.Location = new System.Drawing.Point(168, 24);
      this.btnArduinoPing.Name = "btnArduinoPing";
      this.btnArduinoPing.Size = new System.Drawing.Size(24, 24);
      this.btnArduinoPing.TabIndex = 14;
      this.btnArduinoPing.Text = "P";
      this.btnArduinoPing.UseVisualStyleBackColor = true;
      this.btnArduinoPing.Click += new System.EventHandler(this.btnArduinoPing_Click);
      // 
      // buttonState3
      // 
      this.buttonState3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonState3.Index = 2;
      this.buttonState3.Location = new System.Drawing.Point(304, 24);
      this.buttonState3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.buttonState3.Name = "buttonState3";
      this.buttonState3.On = false;
      this.buttonState3.Size = new System.Drawing.Size(40, 40);
      this.buttonState3.TabIndex = 13;
      this.buttonState3.OnStateChanged += new ArduinoPedalBridge.Delegates.ButtonStateChangedDelegate(this.button_OnStateChanged);
      // 
      // buttonState2
      // 
      this.buttonState2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonState2.Index = 1;
      this.buttonState2.Location = new System.Drawing.Point(256, 24);
      this.buttonState2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.buttonState2.Name = "buttonState2";
      this.buttonState2.On = false;
      this.buttonState2.Size = new System.Drawing.Size(40, 40);
      this.buttonState2.TabIndex = 12;
      this.buttonState2.OnStateChanged += new ArduinoPedalBridge.Delegates.ButtonStateChangedDelegate(this.button_OnStateChanged);
      // 
      // buttonState1
      // 
      this.buttonState1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonState1.Index = 0;
      this.buttonState1.Location = new System.Drawing.Point(208, 24);
      this.buttonState1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.buttonState1.Name = "buttonState1";
      this.buttonState1.On = false;
      this.buttonState1.Size = new System.Drawing.Size(40, 40);
      this.buttonState1.TabIndex = 11;
      this.buttonState1.OnStateChanged += new ArduinoPedalBridge.Delegates.ButtonStateChangedDelegate(this.button_OnStateChanged);
      // 
      // pedalValue
      // 
      this.pedalValue.Horizontal = true;
      this.pedalValue.Location = new System.Drawing.Point(16, 80);
      this.pedalValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.pedalValue.Name = "pedalValue";
      this.pedalValue.Size = new System.Drawing.Size(336, 24);
      this.pedalValue.TabIndex = 10;
      this.pedalValue.Value = 0F;
      // 
      // txtArduinoConnectionBaud
      // 
      this.txtArduinoConnectionBaud.AutoSize = true;
      this.txtArduinoConnectionBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionBaud.Location = new System.Drawing.Point(64, 56);
      this.txtArduinoConnectionBaud.Name = "txtArduinoConnectionBaud";
      this.txtArduinoConnectionBaud.Size = new System.Drawing.Size(11, 13);
      this.txtArduinoConnectionBaud.TabIndex = 5;
      this.txtArduinoConnectionBaud.Text = "-";
      // 
      // txtArduinoConnectionPort
      // 
      this.txtArduinoConnectionPort.AutoSize = true;
      this.txtArduinoConnectionPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionPort.Location = new System.Drawing.Point(64, 40);
      this.txtArduinoConnectionPort.Name = "txtArduinoConnectionPort";
      this.txtArduinoConnectionPort.Size = new System.Drawing.Size(11, 13);
      this.txtArduinoConnectionPort.TabIndex = 4;
      this.txtArduinoConnectionPort.Text = "-";
      // 
      // lblArduinoConnectionBaud
      // 
      this.lblArduinoConnectionBaud.AutoSize = true;
      this.lblArduinoConnectionBaud.Location = new System.Drawing.Point(16, 56);
      this.lblArduinoConnectionBaud.Name = "lblArduinoConnectionBaud";
      this.lblArduinoConnectionBaud.Size = new System.Drawing.Size(32, 13);
      this.lblArduinoConnectionBaud.TabIndex = 3;
      this.lblArduinoConnectionBaud.Text = "Baud";
      // 
      // lblArduinoConnectionPort
      // 
      this.lblArduinoConnectionPort.AutoSize = true;
      this.lblArduinoConnectionPort.Location = new System.Drawing.Point(16, 40);
      this.lblArduinoConnectionPort.Name = "lblArduinoConnectionPort";
      this.lblArduinoConnectionPort.Size = new System.Drawing.Size(26, 13);
      this.lblArduinoConnectionPort.TabIndex = 2;
      this.lblArduinoConnectionPort.Text = "Port";
      // 
      // txtArduinoConnectionStatus
      // 
      this.txtArduinoConnectionStatus.AutoSize = true;
      this.txtArduinoConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionStatus.Location = new System.Drawing.Point(64, 24);
      this.txtArduinoConnectionStatus.Name = "txtArduinoConnectionStatus";
      this.txtArduinoConnectionStatus.Size = new System.Drawing.Size(85, 13);
      this.txtArduinoConnectionStatus.TabIndex = 1;
      this.txtArduinoConnectionStatus.Text = "Disconnected";
      // 
      // lblArduinoConnectionStatus
      // 
      this.lblArduinoConnectionStatus.AutoSize = true;
      this.lblArduinoConnectionStatus.Location = new System.Drawing.Point(16, 24);
      this.lblArduinoConnectionStatus.Name = "lblArduinoConnectionStatus";
      this.lblArduinoConnectionStatus.Size = new System.Drawing.Size(37, 13);
      this.lblArduinoConnectionStatus.TabIndex = 0;
      this.lblArduinoConnectionStatus.Text = "Status";
      // 
      // btnSettings
      // 
      this.btnSettings.Location = new System.Drawing.Point(5, 5);
      this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(59, 21);
      this.btnSettings.TabIndex = 6;
      this.btnSettings.Text = "Settings";
      this.btnSettings.UseVisualStyleBackColor = true;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // grpMIDIDevice
      // 
      this.grpMIDIDevice.Controls.Add(this.txtMIDIDeviceName);
      this.grpMIDIDevice.Controls.Add(this.label1);
      this.grpMIDIDevice.Location = new System.Drawing.Point(8, 152);
      this.grpMIDIDevice.Name = "grpMIDIDevice";
      this.grpMIDIDevice.Size = new System.Drawing.Size(368, 312);
      this.grpMIDIDevice.TabIndex = 7;
      this.grpMIDIDevice.TabStop = false;
      this.grpMIDIDevice.Text = "MIDI device";
      // 
      // txtMIDIDeviceName
      // 
      this.txtMIDIDeviceName.AutoSize = true;
      this.txtMIDIDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMIDIDeviceName.Location = new System.Drawing.Point(64, 24);
      this.txtMIDIDeviceName.Name = "txtMIDIDeviceName";
      this.txtMIDIDeviceName.Size = new System.Drawing.Size(85, 13);
      this.txtMIDIDeviceName.TabIndex = 2;
      this.txtMIDIDeviceName.Text = "Disconnected";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(96, 480);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(72, 24);
      this.button1.TabIndex = 15;
      this.button1.Text = "P";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(184, 480);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(72, 24);
      this.button2.TabIndex = 16;
      this.button2.Text = "P";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 576);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.grpMIDIDevice);
      this.Controls.Add(this.btnSettings);
      this.Controls.Add(this.grpArduinoConnection);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.grpArduinoConnection.ResumeLayout(false);
      this.grpArduinoConnection.PerformLayout();
      this.grpMIDIDevice.ResumeLayout(false);
      this.grpMIDIDevice.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.GroupBox grpArduinoConnection;
    private System.Windows.Forms.Label txtArduinoConnectionStatus;
    private System.Windows.Forms.Label lblArduinoConnectionStatus;
    private System.Windows.Forms.Label txtArduinoConnectionBaud;
    private System.Windows.Forms.Label txtArduinoConnectionPort;
    private System.Windows.Forms.Label lblArduinoConnectionBaud;
    private System.Windows.Forms.Label lblArduinoConnectionPort;
    private PotVisualizer pedalValue;
    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.GroupBox grpMIDIDevice;
    private System.Windows.Forms.Label txtMIDIDeviceName;
    private System.Windows.Forms.Label label1;
    private ButtonState buttonState3;
    private ButtonState buttonState2;
    private ButtonState buttonState1;
    private System.Windows.Forms.Button btnArduinoPing;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}

