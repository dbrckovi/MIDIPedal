
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
      this.cmbSerialPort = new System.Windows.Forms.ComboBox();
      this.lblSerialPort = new System.Windows.Forms.Label();
      this.lblSerialBaud = new System.Windows.Forms.Label();
      this.cmbSerialBaud = new System.Windows.Forms.ComboBox();
      this.btnTestSerial = new System.Windows.Forms.Button();
      this.grpArduinoConnection = new System.Windows.Forms.GroupBox();
      this.txtArduinoPedalValue = new System.Windows.Forms.Label();
      this.lblArduinoPedal = new System.Windows.Forms.Label();
      this.txtArduinoButtons = new System.Windows.Forms.Label();
      this.lblArduinoButtons = new System.Windows.Forms.Label();
      this.txtArduinoConnectionBaud = new System.Windows.Forms.Label();
      this.txtArduinoConnectionPort = new System.Windows.Forms.Label();
      this.lblArduinoConnectionBaud = new System.Windows.Forms.Label();
      this.lblArduinoConnectionPort = new System.Windows.Forms.Label();
      this.txtArduinoConnectionStatus = new System.Windows.Forms.Label();
      this.lblArduinoConnectionStatus = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.grpArduinoConnection.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmbSerialPort
      // 
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(136, 344);
      this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(2);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(119, 21);
      this.cmbSerialPort.TabIndex = 0;
      // 
      // lblSerialPort
      // 
      this.lblSerialPort.AutoSize = true;
      this.lblSerialPort.Location = new System.Drawing.Point(72, 344);
      this.lblSerialPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSerialPort.Name = "lblSerialPort";
      this.lblSerialPort.Size = new System.Drawing.Size(54, 13);
      this.lblSerialPort.TabIndex = 1;
      this.lblSerialPort.Text = "Serial port";
      // 
      // lblSerialBaud
      // 
      this.lblSerialBaud.AutoSize = true;
      this.lblSerialBaud.Location = new System.Drawing.Point(72, 365);
      this.lblSerialBaud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSerialBaud.Name = "lblSerialBaud";
      this.lblSerialBaud.Size = new System.Drawing.Size(32, 13);
      this.lblSerialBaud.TabIndex = 3;
      this.lblSerialBaud.Text = "Baud";
      // 
      // cmbSerialBaud
      // 
      this.cmbSerialBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialBaud.FormattingEnabled = true;
      this.cmbSerialBaud.Location = new System.Drawing.Point(136, 365);
      this.cmbSerialBaud.Margin = new System.Windows.Forms.Padding(2);
      this.cmbSerialBaud.Name = "cmbSerialBaud";
      this.cmbSerialBaud.Size = new System.Drawing.Size(119, 21);
      this.cmbSerialBaud.TabIndex = 2;
      // 
      // btnTestSerial
      // 
      this.btnTestSerial.Location = new System.Drawing.Point(264, 344);
      this.btnTestSerial.Margin = new System.Windows.Forms.Padding(2);
      this.btnTestSerial.Name = "btnTestSerial";
      this.btnTestSerial.Size = new System.Drawing.Size(117, 26);
      this.btnTestSerial.TabIndex = 4;
      this.btnTestSerial.Text = "Test serial port";
      this.btnTestSerial.UseVisualStyleBackColor = true;
      this.btnTestSerial.Click += new System.EventHandler(this.btnTestSerial_Click);
      // 
      // grpArduinoConnection
      // 
      this.grpArduinoConnection.Controls.Add(this.txtArduinoPedalValue);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoPedal);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoButtons);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoButtons);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionBaud);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionPort);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionBaud);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionPort);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionStatus);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionStatus);
      this.grpArduinoConnection.Location = new System.Drawing.Point(8, 8);
      this.grpArduinoConnection.Name = "grpArduinoConnection";
      this.grpArduinoConnection.Size = new System.Drawing.Size(168, 144);
      this.grpArduinoConnection.TabIndex = 5;
      this.grpArduinoConnection.TabStop = false;
      this.grpArduinoConnection.Text = "Arduino connection";
      // 
      // txtArduinoPedalValue
      // 
      this.txtArduinoPedalValue.AutoSize = true;
      this.txtArduinoPedalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoPedalValue.Location = new System.Drawing.Point(64, 120);
      this.txtArduinoPedalValue.Name = "txtArduinoPedalValue";
      this.txtArduinoPedalValue.Size = new System.Drawing.Size(11, 13);
      this.txtArduinoPedalValue.TabIndex = 9;
      this.txtArduinoPedalValue.Text = "-";
      // 
      // lblArduinoPedal
      // 
      this.lblArduinoPedal.AutoSize = true;
      this.lblArduinoPedal.Location = new System.Drawing.Point(16, 120);
      this.lblArduinoPedal.Name = "lblArduinoPedal";
      this.lblArduinoPedal.Size = new System.Drawing.Size(34, 13);
      this.lblArduinoPedal.TabIndex = 8;
      this.lblArduinoPedal.Text = "Pedal";
      // 
      // txtArduinoButtons
      // 
      this.txtArduinoButtons.AutoSize = true;
      this.txtArduinoButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoButtons.Location = new System.Drawing.Point(64, 96);
      this.txtArduinoButtons.Name = "txtArduinoButtons";
      this.txtArduinoButtons.Size = new System.Drawing.Size(11, 13);
      this.txtArduinoButtons.TabIndex = 7;
      this.txtArduinoButtons.Text = "-";
      // 
      // lblArduinoButtons
      // 
      this.lblArduinoButtons.AutoSize = true;
      this.lblArduinoButtons.Location = new System.Drawing.Point(16, 96);
      this.lblArduinoButtons.Name = "lblArduinoButtons";
      this.lblArduinoButtons.Size = new System.Drawing.Size(43, 13);
      this.lblArduinoButtons.TabIndex = 6;
      this.lblArduinoButtons.Text = "Buttons";
      // 
      // txtArduinoConnectionBaud
      // 
      this.txtArduinoConnectionBaud.AutoSize = true;
      this.txtArduinoConnectionBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionBaud.Location = new System.Drawing.Point(64, 72);
      this.txtArduinoConnectionBaud.Name = "txtArduinoConnectionBaud";
      this.txtArduinoConnectionBaud.Size = new System.Drawing.Size(11, 13);
      this.txtArduinoConnectionBaud.TabIndex = 5;
      this.txtArduinoConnectionBaud.Text = "-";
      // 
      // txtArduinoConnectionPort
      // 
      this.txtArduinoConnectionPort.AutoSize = true;
      this.txtArduinoConnectionPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionPort.Location = new System.Drawing.Point(64, 48);
      this.txtArduinoConnectionPort.Name = "txtArduinoConnectionPort";
      this.txtArduinoConnectionPort.Size = new System.Drawing.Size(11, 13);
      this.txtArduinoConnectionPort.TabIndex = 4;
      this.txtArduinoConnectionPort.Text = "-";
      // 
      // lblArduinoConnectionBaud
      // 
      this.lblArduinoConnectionBaud.AutoSize = true;
      this.lblArduinoConnectionBaud.Location = new System.Drawing.Point(16, 72);
      this.lblArduinoConnectionBaud.Name = "lblArduinoConnectionBaud";
      this.lblArduinoConnectionBaud.Size = new System.Drawing.Size(32, 13);
      this.lblArduinoConnectionBaud.TabIndex = 3;
      this.lblArduinoConnectionBaud.Text = "Baud";
      // 
      // lblArduinoConnectionPort
      // 
      this.lblArduinoConnectionPort.AutoSize = true;
      this.lblArduinoConnectionPort.Location = new System.Drawing.Point(16, 48);
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
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Location = new System.Drawing.Point(184, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(376, 144);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Arduino connection";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(64, 24);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(85, 13);
      this.label9.TabIndex = 1;
      this.label9.Text = "Disconnected";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(16, 24);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(37, 13);
      this.label10.TabIndex = 0;
      this.label10.Text = "Status";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(715, 396);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.grpArduinoConnection);
      this.Controls.Add(this.btnTestSerial);
      this.Controls.Add(this.lblSerialBaud);
      this.Controls.Add(this.cmbSerialBaud);
      this.Controls.Add(this.lblSerialPort);
      this.Controls.Add(this.cmbSerialPort);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.grpArduinoConnection.ResumeLayout(false);
      this.grpArduinoConnection.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbSerialPort;
    private System.Windows.Forms.Label lblSerialPort;
    private System.Windows.Forms.Label lblSerialBaud;
    private System.Windows.Forms.ComboBox cmbSerialBaud;
    private System.Windows.Forms.Button btnTestSerial;
    private System.Windows.Forms.GroupBox grpArduinoConnection;
    private System.Windows.Forms.Label txtArduinoConnectionStatus;
    private System.Windows.Forms.Label lblArduinoConnectionStatus;
    private System.Windows.Forms.Label txtArduinoConnectionBaud;
    private System.Windows.Forms.Label txtArduinoConnectionPort;
    private System.Windows.Forms.Label lblArduinoConnectionBaud;
    private System.Windows.Forms.Label lblArduinoConnectionPort;
    private System.Windows.Forms.Label txtArduinoButtons;
    private System.Windows.Forms.Label lblArduinoButtons;
    private System.Windows.Forms.Label txtArduinoPedalValue;
    private System.Windows.Forms.Label lblArduinoPedal;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
  }
}

