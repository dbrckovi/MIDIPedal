namespace ArduinoPedalBridge
{
  partial class frmButtonEventSettingEditor
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
      this.numVolume = new System.Windows.Forms.NumericUpDown();
      this.numNote = new System.Windows.Forms.NumericUpDown();
      this.numChannel = new System.Windows.Forms.NumericUpDown();
      this.cmbMessageType = new System.Windows.Forms.ComboBox();
      this.cmbButtonEvent = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbButtonIndex = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNote)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChannel)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // numVolume
      // 
      this.numVolume.Location = new System.Drawing.Point(216, 48);
      this.numVolume.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
      this.numVolume.Name = "numVolume";
      this.numVolume.Size = new System.Drawing.Size(48, 20);
      this.numVolume.TabIndex = 13;
      // 
      // numNote
      // 
      this.numNote.Location = new System.Drawing.Point(216, 24);
      this.numNote.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
      this.numNote.Name = "numNote";
      this.numNote.Size = new System.Drawing.Size(48, 20);
      this.numNote.TabIndex = 12;
      // 
      // numChannel
      // 
      this.numChannel.Location = new System.Drawing.Point(72, 24);
      this.numChannel.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
      this.numChannel.Name = "numChannel";
      this.numChannel.Size = new System.Drawing.Size(72, 20);
      this.numChannel.TabIndex = 11;
      // 
      // cmbMessageType
      // 
      this.cmbMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMessageType.FormattingEnabled = true;
      this.cmbMessageType.Location = new System.Drawing.Point(72, 48);
      this.cmbMessageType.Name = "cmbMessageType";
      this.cmbMessageType.Size = new System.Drawing.Size(72, 21);
      this.cmbMessageType.TabIndex = 10;
      // 
      // cmbButtonEvent
      // 
      this.cmbButtonEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbButtonEvent.FormattingEnabled = true;
      this.cmbButtonEvent.Location = new System.Drawing.Point(72, 48);
      this.cmbButtonEvent.Name = "cmbButtonEvent";
      this.cmbButtonEvent.Size = new System.Drawing.Size(72, 21);
      this.cmbButtonEvent.TabIndex = 14;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Event";
      // 
      // cmbButtonIndex
      // 
      this.cmbButtonIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbButtonIndex.FormattingEnabled = true;
      this.cmbButtonIndex.Location = new System.Drawing.Point(72, 24);
      this.cmbButtonIndex.Name = "cmbButtonIndex";
      this.cmbButtonIndex.Size = new System.Drawing.Size(72, 21);
      this.cmbButtonIndex.TabIndex = 16;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 17;
      this.label2.Text = "Button";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 24);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 18;
      this.label3.Text = "Channel";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(50, 13);
      this.label4.TabIndex = 19;
      this.label4.Text = "Message";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(160, 24);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(30, 13);
      this.label5.TabIndex = 20;
      this.label5.Text = "Note";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(160, 48);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(42, 13);
      this.label6.TabIndex = 21;
      this.label6.Text = "Volume";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cmbButtonIndex);
      this.groupBox1.Controls.Add(this.cmbButtonEvent);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(160, 80);
      this.groupBox1.TabIndex = 22;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Button event";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.numChannel);
      this.groupBox2.Controls.Add(this.cmbMessageType);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.numNote);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.numVolume);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Location = new System.Drawing.Point(176, 8);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(280, 80);
      this.groupBox2.TabIndex = 23;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "MIDI message";
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(184, 104);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(104, 32);
      this.btnOK.TabIndex = 24;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(352, 104);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(104, 32);
      this.btnCancel.TabIndex = 25;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmButtonEventSettingEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(470, 155);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmButtonEventSettingEditor";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Button event";
      this.Load += new System.EventHandler(this.frmButtonEventSettingEditor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNote)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChannel)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numVolume;
    private System.Windows.Forms.NumericUpDown numNote;
    private System.Windows.Forms.NumericUpDown numChannel;
    private System.Windows.Forms.ComboBox cmbMessageType;
    private System.Windows.Forms.ComboBox cmbButtonEvent;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbButtonIndex;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}