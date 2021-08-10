
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
      this.btnConnect = new System.Windows.Forms.Button();
      this.lblButton1 = new System.Windows.Forms.Label();
      this.lblButton2 = new System.Windows.Forms.Label();
      this.lblPot = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmbSerialPort
      // 
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(75, 10);
      this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(119, 21);
      this.cmbSerialPort.TabIndex = 0;
      // 
      // lblSerialPort
      // 
      this.lblSerialPort.AutoSize = true;
      this.lblSerialPort.Location = new System.Drawing.Point(11, 10);
      this.lblSerialPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSerialPort.Name = "lblSerialPort";
      this.lblSerialPort.Size = new System.Drawing.Size(54, 13);
      this.lblSerialPort.TabIndex = 1;
      this.lblSerialPort.Text = "Serial port";
      // 
      // lblSerialBaud
      // 
      this.lblSerialBaud.AutoSize = true;
      this.lblSerialBaud.Location = new System.Drawing.Point(11, 31);
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
      this.cmbSerialBaud.Location = new System.Drawing.Point(75, 31);
      this.cmbSerialBaud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cmbSerialBaud.Name = "cmbSerialBaud";
      this.cmbSerialBaud.Size = new System.Drawing.Size(119, 21);
      this.cmbSerialBaud.TabIndex = 2;
      // 
      // btnTestSerial
      // 
      this.btnTestSerial.Location = new System.Drawing.Point(203, 10);
      this.btnTestSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnTestSerial.Name = "btnTestSerial";
      this.btnTestSerial.Size = new System.Drawing.Size(117, 26);
      this.btnTestSerial.TabIndex = 4;
      this.btnTestSerial.Text = "Test serial port";
      this.btnTestSerial.UseVisualStyleBackColor = true;
      this.btnTestSerial.Click += new System.EventHandler(this.btnTestSerial_Click);
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(168, 88);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(112, 32);
      this.btnConnect.TabIndex = 5;
      this.btnConnect.Text = "button1";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // lblButton1
      // 
      this.lblButton1.AutoSize = true;
      this.lblButton1.Location = new System.Drawing.Point(24, 96);
      this.lblButton1.Name = "lblButton1";
      this.lblButton1.Size = new System.Drawing.Size(35, 13);
      this.lblButton1.TabIndex = 6;
      this.lblButton1.Text = "label1";
      // 
      // lblButton2
      // 
      this.lblButton2.AutoSize = true;
      this.lblButton2.Location = new System.Drawing.Point(24, 120);
      this.lblButton2.Name = "lblButton2";
      this.lblButton2.Size = new System.Drawing.Size(35, 13);
      this.lblButton2.TabIndex = 7;
      this.lblButton2.Text = "label2";
      // 
      // lblPot
      // 
      this.lblPot.AutoSize = true;
      this.lblPot.Location = new System.Drawing.Point(24, 144);
      this.lblPot.Name = "lblPot";
      this.lblPot.Size = new System.Drawing.Size(35, 13);
      this.lblPot.TabIndex = 8;
      this.lblPot.Text = "label3";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(731, 484);
      this.Controls.Add(this.lblPot);
      this.Controls.Add(this.lblButton2);
      this.Controls.Add(this.lblButton1);
      this.Controls.Add(this.btnConnect);
      this.Controls.Add(this.btnTestSerial);
      this.Controls.Add(this.lblSerialBaud);
      this.Controls.Add(this.cmbSerialBaud);
      this.Controls.Add(this.lblSerialPort);
      this.Controls.Add(this.cmbSerialPort);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
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
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Label lblButton1;
    private System.Windows.Forms.Label lblButton2;
    private System.Windows.Forms.Label lblPot;
  }
}

