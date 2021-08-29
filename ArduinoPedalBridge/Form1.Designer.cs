
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
      this.txtArduinoButtons = new System.Windows.Forms.Label();
      this.lblArduinoButtons = new System.Windows.Forms.Label();
      this.txtArduinoConnectionBaud = new System.Windows.Forms.Label();
      this.txtArduinoConnectionPort = new System.Windows.Forms.Label();
      this.lblArduinoConnectionBaud = new System.Windows.Forms.Label();
      this.lblArduinoConnectionPort = new System.Windows.Forms.Label();
      this.txtArduinoConnectionStatus = new System.Windows.Forms.Label();
      this.lblArduinoConnectionStatus = new System.Windows.Forms.Label();
      this.pedalValue = new ArduinoPedalBridge.PotVisualizer();
      this.btnSettings = new System.Windows.Forms.Button();
      this.grpArduinoConnection.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpArduinoConnection
      // 
      this.grpArduinoConnection.Controls.Add(this.pedalValue);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoButtons);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoButtons);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionBaud);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionPort);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionBaud);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionPort);
      this.grpArduinoConnection.Controls.Add(this.txtArduinoConnectionStatus);
      this.grpArduinoConnection.Controls.Add(this.lblArduinoConnectionStatus);
      this.grpArduinoConnection.Location = new System.Drawing.Point(12, 80);
      this.grpArduinoConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpArduinoConnection.Name = "grpArduinoConnection";
      this.grpArduinoConnection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpArduinoConnection.Size = new System.Drawing.Size(324, 185);
      this.grpArduinoConnection.TabIndex = 5;
      this.grpArduinoConnection.TabStop = false;
      this.grpArduinoConnection.Text = "Arduino connection";
      // 
      // txtArduinoButtons
      // 
      this.txtArduinoButtons.AutoSize = true;
      this.txtArduinoButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoButtons.Location = new System.Drawing.Point(96, 148);
      this.txtArduinoButtons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.txtArduinoButtons.Name = "txtArduinoButtons";
      this.txtArduinoButtons.Size = new System.Drawing.Size(16, 20);
      this.txtArduinoButtons.TabIndex = 7;
      this.txtArduinoButtons.Text = "-";
      // 
      // lblArduinoButtons
      // 
      this.lblArduinoButtons.AutoSize = true;
      this.lblArduinoButtons.Location = new System.Drawing.Point(24, 148);
      this.lblArduinoButtons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblArduinoButtons.Name = "lblArduinoButtons";
      this.lblArduinoButtons.Size = new System.Drawing.Size(65, 20);
      this.lblArduinoButtons.TabIndex = 6;
      this.lblArduinoButtons.Text = "Buttons";
      // 
      // txtArduinoConnectionBaud
      // 
      this.txtArduinoConnectionBaud.AutoSize = true;
      this.txtArduinoConnectionBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionBaud.Location = new System.Drawing.Point(96, 111);
      this.txtArduinoConnectionBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.txtArduinoConnectionBaud.Name = "txtArduinoConnectionBaud";
      this.txtArduinoConnectionBaud.Size = new System.Drawing.Size(16, 20);
      this.txtArduinoConnectionBaud.TabIndex = 5;
      this.txtArduinoConnectionBaud.Text = "-";
      // 
      // txtArduinoConnectionPort
      // 
      this.txtArduinoConnectionPort.AutoSize = true;
      this.txtArduinoConnectionPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionPort.Location = new System.Drawing.Point(96, 74);
      this.txtArduinoConnectionPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.txtArduinoConnectionPort.Name = "txtArduinoConnectionPort";
      this.txtArduinoConnectionPort.Size = new System.Drawing.Size(16, 20);
      this.txtArduinoConnectionPort.TabIndex = 4;
      this.txtArduinoConnectionPort.Text = "-";
      // 
      // lblArduinoConnectionBaud
      // 
      this.lblArduinoConnectionBaud.AutoSize = true;
      this.lblArduinoConnectionBaud.Location = new System.Drawing.Point(24, 111);
      this.lblArduinoConnectionBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblArduinoConnectionBaud.Name = "lblArduinoConnectionBaud";
      this.lblArduinoConnectionBaud.Size = new System.Drawing.Size(47, 20);
      this.lblArduinoConnectionBaud.TabIndex = 3;
      this.lblArduinoConnectionBaud.Text = "Baud";
      // 
      // lblArduinoConnectionPort
      // 
      this.lblArduinoConnectionPort.AutoSize = true;
      this.lblArduinoConnectionPort.Location = new System.Drawing.Point(24, 74);
      this.lblArduinoConnectionPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblArduinoConnectionPort.Name = "lblArduinoConnectionPort";
      this.lblArduinoConnectionPort.Size = new System.Drawing.Size(38, 20);
      this.lblArduinoConnectionPort.TabIndex = 2;
      this.lblArduinoConnectionPort.Text = "Port";
      // 
      // txtArduinoConnectionStatus
      // 
      this.txtArduinoConnectionStatus.AutoSize = true;
      this.txtArduinoConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtArduinoConnectionStatus.Location = new System.Drawing.Point(96, 37);
      this.txtArduinoConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.txtArduinoConnectionStatus.Name = "txtArduinoConnectionStatus";
      this.txtArduinoConnectionStatus.Size = new System.Drawing.Size(124, 20);
      this.txtArduinoConnectionStatus.TabIndex = 1;
      this.txtArduinoConnectionStatus.Text = "Disconnected";
      // 
      // lblArduinoConnectionStatus
      // 
      this.lblArduinoConnectionStatus.AutoSize = true;
      this.lblArduinoConnectionStatus.Location = new System.Drawing.Point(24, 37);
      this.lblArduinoConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblArduinoConnectionStatus.Name = "lblArduinoConnectionStatus";
      this.lblArduinoConnectionStatus.Size = new System.Drawing.Size(56, 20);
      this.lblArduinoConnectionStatus.TabIndex = 0;
      this.lblArduinoConnectionStatus.Text = "Status";
      // 
      // pedalValue
      // 
      this.pedalValue.Horizontal = false;
      this.pedalValue.Location = new System.Drawing.Point(264, 25);
      this.pedalValue.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.pedalValue.Name = "pedalValue";
      this.pedalValue.Size = new System.Drawing.Size(48, 148);
      this.pedalValue.TabIndex = 10;
      this.pedalValue.Value = 0F;
      // 
      // btnSettings
      // 
      this.btnSettings.Location = new System.Drawing.Point(8, 8);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(88, 32);
      this.btnSettings.TabIndex = 6;
      this.btnSettings.Text = "Settings";
      this.btnSettings.UseVisualStyleBackColor = true;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1072, 609);
      this.Controls.Add(this.btnSettings);
      this.Controls.Add(this.grpArduinoConnection);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.grpArduinoConnection.ResumeLayout(false);
      this.grpArduinoConnection.PerformLayout();
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
    private System.Windows.Forms.Label txtArduinoButtons;
    private System.Windows.Forms.Label lblArduinoButtons;
    private PotVisualizer pedalValue;
    private System.Windows.Forms.Button btnSettings;
  }
}

