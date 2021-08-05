namespace MIDITest
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
      this.btnON = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnOFF = new System.Windows.Forms.Button();
      this.trackVolume = new System.Windows.Forms.TrackBar();
      this.numChannel = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numNote = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.lnkClearLog = new System.Windows.Forms.LinkLabel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.numControllerChannel = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.numController = new System.Windows.Forms.NumericUpDown();
      this.trackControllerValue = new System.Windows.Forms.TrackBar();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChannel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNote)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numControllerChannel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numController)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackControllerValue)).BeginInit();
      this.SuspendLayout();
      // 
      // btnON
      // 
      this.btnON.Location = new System.Drawing.Point(56, 72);
      this.btnON.Name = "btnON";
      this.btnON.Size = new System.Drawing.Size(72, 32);
      this.btnON.TabIndex = 0;
      this.btnON.Text = "ON";
      this.btnON.UseVisualStyleBackColor = true;
      this.btnON.Click += new System.EventHandler(this.btnON_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.numNote);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.numChannel);
      this.groupBox1.Controls.Add(this.trackVolume);
      this.groupBox1.Controls.Add(this.btnOFF);
      this.groupBox1.Controls.Add(this.btnON);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(216, 112);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Note";
      // 
      // btnOFF
      // 
      this.btnOFF.Location = new System.Drawing.Point(136, 72);
      this.btnOFF.Name = "btnOFF";
      this.btnOFF.Size = new System.Drawing.Size(72, 32);
      this.btnOFF.TabIndex = 1;
      this.btnOFF.Text = "OFF";
      this.btnOFF.UseVisualStyleBackColor = true;
      this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
      // 
      // trackVolume
      // 
      this.trackVolume.AutoSize = false;
      this.trackVolume.Location = new System.Drawing.Point(56, 40);
      this.trackVolume.Maximum = 127;
      this.trackVolume.Name = "trackVolume";
      this.trackVolume.Size = new System.Drawing.Size(152, 32);
      this.trackVolume.TabIndex = 2;
      this.trackVolume.TickFrequency = 8;
      // 
      // numChannel
      // 
      this.numChannel.Location = new System.Drawing.Point(56, 16);
      this.numChannel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
      this.numChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numChannel.Name = "numChannel";
      this.numChannel.Size = new System.Drawing.Size(56, 20);
      this.numChannel.TabIndex = 3;
      this.numChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Channel";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(120, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Note";
      // 
      // numNote
      // 
      this.numNote.Location = new System.Drawing.Point(152, 16);
      this.numNote.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
      this.numNote.Name = "numNote";
      this.numNote.Size = new System.Drawing.Size(56, 20);
      this.numNote.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 40);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Volume";
      // 
      // txtLog
      // 
      this.txtLog.BackColor = System.Drawing.Color.White;
      this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtLog.Location = new System.Drawing.Point(3, 40);
      this.txtLog.Name = "txtLog";
      this.txtLog.ReadOnly = true;
      this.txtLog.Size = new System.Drawing.Size(951, 422);
      this.txtLog.TabIndex = 2;
      this.txtLog.Text = "";
      // 
      // lnkClearLog
      // 
      this.lnkClearLog.AutoSize = true;
      this.lnkClearLog.Location = new System.Drawing.Point(5, 7);
      this.lnkClearLog.Name = "lnkClearLog";
      this.lnkClearLog.Size = new System.Drawing.Size(48, 13);
      this.lnkClearLog.TabIndex = 8;
      this.lnkClearLog.TabStop = true;
      this.lnkClearLog.Text = "Clear log";
      this.lnkClearLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearLog_LinkClicked);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtLog);
      this.groupBox2.Controls.Add(this.panel1);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 112);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(957, 465);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Log";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.trackControllerValue);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Controls.Add(this.numController);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.numControllerChannel);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox3.Location = new System.Drawing.Point(216, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(256, 112);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Controller";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lnkClearLog);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(951, 24);
      this.panel1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox3);
      this.panel2.Controls.Add(this.groupBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(957, 112);
      this.panel2.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Channel";
      // 
      // numControllerChannel
      // 
      this.numControllerChannel.Location = new System.Drawing.Point(56, 16);
      this.numControllerChannel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
      this.numControllerChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numControllerChannel.Name = "numControllerChannel";
      this.numControllerChannel.Size = new System.Drawing.Size(56, 20);
      this.numControllerChannel.TabIndex = 5;
      this.numControllerChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(120, 16);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(51, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Controller";
      // 
      // numController
      // 
      this.numController.Location = new System.Drawing.Point(184, 16);
      this.numController.Maximum = new decimal(new int[] {
            119,
            0,
            0,
            0});
      this.numController.Name = "numController";
      this.numController.Size = new System.Drawing.Size(56, 20);
      this.numController.TabIndex = 7;
      // 
      // trackControllerValue
      // 
      this.trackControllerValue.AutoSize = false;
      this.trackControllerValue.Location = new System.Drawing.Point(8, 40);
      this.trackControllerValue.Maximum = 127;
      this.trackControllerValue.Name = "trackControllerValue";
      this.trackControllerValue.Size = new System.Drawing.Size(232, 32);
      this.trackControllerValue.TabIndex = 9;
      this.trackControllerValue.TickFrequency = 8;
      this.trackControllerValue.Scroll += new System.EventHandler(this.numControllerValue_Scroll);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(957, 577);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.panel2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChannel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNote)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numControllerChannel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numController)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackControllerValue)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnON;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown numChannel;
    private System.Windows.Forms.TrackBar trackVolume;
    private System.Windows.Forms.Button btnOFF;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numNote;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.LinkLabel lnkClearLog;
    private System.Windows.Forms.RichTextBox txtLog;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TrackBar trackControllerValue;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numController;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numControllerChannel;
    private System.Windows.Forms.Panel panel2;
  }
}

