
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
      this.SuspendLayout();
      // 
      // cmbSerialPort
      // 
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(112, 16);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(176, 28);
      this.cmbSerialPort.TabIndex = 0;
      // 
      // lblSerialPort
      // 
      this.lblSerialPort.AutoSize = true;
      this.lblSerialPort.Location = new System.Drawing.Point(16, 16);
      this.lblSerialPort.Name = "lblSerialPort";
      this.lblSerialPort.Size = new System.Drawing.Size(81, 20);
      this.lblSerialPort.TabIndex = 1;
      this.lblSerialPort.Text = "Serial port";
      // 
      // lblSerialBaud
      // 
      this.lblSerialBaud.AutoSize = true;
      this.lblSerialBaud.Location = new System.Drawing.Point(16, 48);
      this.lblSerialBaud.Name = "lblSerialBaud";
      this.lblSerialBaud.Size = new System.Drawing.Size(47, 20);
      this.lblSerialBaud.TabIndex = 3;
      this.lblSerialBaud.Text = "Baud";
      // 
      // cmbSerialBaud
      // 
      this.cmbSerialBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialBaud.FormattingEnabled = true;
      this.cmbSerialBaud.Location = new System.Drawing.Point(112, 48);
      this.cmbSerialBaud.Name = "cmbSerialBaud";
      this.cmbSerialBaud.Size = new System.Drawing.Size(176, 28);
      this.cmbSerialBaud.TabIndex = 2;
      // 
      // btnTestSerial
      // 
      this.btnTestSerial.Location = new System.Drawing.Point(304, 16);
      this.btnTestSerial.Name = "btnTestSerial";
      this.btnTestSerial.Size = new System.Drawing.Size(176, 40);
      this.btnTestSerial.TabIndex = 4;
      this.btnTestSerial.Text = "Test serial port";
      this.btnTestSerial.UseVisualStyleBackColor = true;
      this.btnTestSerial.Click += new System.EventHandler(this.btnTestSerial_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(641, 404);
      this.Controls.Add(this.btnTestSerial);
      this.Controls.Add(this.lblSerialBaud);
      this.Controls.Add(this.cmbSerialBaud);
      this.Controls.Add(this.lblSerialPort);
      this.Controls.Add(this.cmbSerialPort);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbSerialPort;
    private System.Windows.Forms.Label lblSerialPort;
    private System.Windows.Forms.Label lblSerialBaud;
    private System.Windows.Forms.ComboBox cmbSerialBaud;
    private System.Windows.Forms.Button btnTestSerial;
  }
}

