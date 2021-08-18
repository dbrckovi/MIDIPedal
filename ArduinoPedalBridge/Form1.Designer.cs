
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmbSerialPort
      // 
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(112, 15);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(176, 28);
      this.cmbSerialPort.TabIndex = 0;
      // 
      // lblSerialPort
      // 
      this.lblSerialPort.AutoSize = true;
      this.lblSerialPort.Location = new System.Drawing.Point(16, 15);
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
      this.btnTestSerial.Location = new System.Drawing.Point(304, 15);
      this.btnTestSerial.Name = "btnTestSerial";
      this.btnTestSerial.Size = new System.Drawing.Size(176, 40);
      this.btnTestSerial.TabIndex = 4;
      this.btnTestSerial.Text = "Test serial port";
      this.btnTestSerial.UseVisualStyleBackColor = true;
      this.btnTestSerial.Click += new System.EventHandler(this.btnTestSerial_Click);
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(432, 312);
      this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(168, 49);
      this.btnConnect.TabIndex = 5;
      this.btnConnect.Text = "button1";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // lblButton1
      // 
      this.lblButton1.AutoSize = true;
      this.lblButton1.Location = new System.Drawing.Point(36, 148);
      this.lblButton1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblButton1.Name = "lblButton1";
      this.lblButton1.Size = new System.Drawing.Size(51, 20);
      this.lblButton1.TabIndex = 6;
      this.lblButton1.Text = "label1";
      // 
      // lblButton2
      // 
      this.lblButton2.AutoSize = true;
      this.lblButton2.Location = new System.Drawing.Point(36, 185);
      this.lblButton2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblButton2.Name = "lblButton2";
      this.lblButton2.Size = new System.Drawing.Size(51, 20);
      this.lblButton2.TabIndex = 7;
      this.lblButton2.Text = "label2";
      // 
      // lblPot
      // 
      this.lblPot.AutoSize = true;
      this.lblPot.Location = new System.Drawing.Point(36, 222);
      this.lblPot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblPot.Name = "lblPot";
      this.lblPot.Size = new System.Drawing.Size(51, 20);
      this.lblPot.TabIndex = 8;
      this.lblPot.Text = "label3";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(272, 312);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(144, 26);
      this.textBox1.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(632, 312);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 20);
      this.label1.TabIndex = 10;
      this.label1.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1096, 745);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.lblPot);
      this.Controls.Add(this.lblButton2);
      this.Controls.Add(this.lblButton1);
      this.Controls.Add(this.btnConnect);
      this.Controls.Add(this.btnTestSerial);
      this.Controls.Add(this.lblSerialBaud);
      this.Controls.Add(this.cmbSerialBaud);
      this.Controls.Add(this.lblSerialPort);
      this.Controls.Add(this.cmbSerialPort);
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
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
  }
}

