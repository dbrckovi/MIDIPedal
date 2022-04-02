namespace Chordale
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
      this.components = new System.ComponentModel.Container();
      this.fretboardVisualizer1 = new Chordale.FretboardVisualizer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblVisualizedName = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.chkIncludeDominant = new Chordale.LabelCheckbox();
      this.chkIncludeMinor = new Chordale.LabelCheckbox();
      this.chkIncludeMajor = new Chordale.LabelCheckbox();
      this.lblAuto = new System.Windows.Forms.Label();
      this.lblBPM = new System.Windows.Forms.Label();
      this.trackBPM = new System.Windows.Forms.TrackBar();
      this.panel5 = new System.Windows.Forms.Panel();
      this.lstChords = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.lstScales = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.autoVisualizer = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBPM)).BeginInit();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // fretboardVisualizer1
      // 
      this.fretboardVisualizer1.BackColor = System.Drawing.Color.White;
      this.fretboardVisualizer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fretboardVisualizer1.Location = new System.Drawing.Point(48, 136);
      this.fretboardVisualizer1.Name = "fretboardVisualizer1";
      this.fretboardVisualizer1.Size = new System.Drawing.Size(1072, 544);
      this.fretboardVisualizer1.TabIndex = 0;
      this.fretboardVisualizer1.Zoom = 2.8F;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lblVisualizedName);
      this.panel1.Controls.Add(this.panel4);
      this.panel1.Controls.Add(this.panel5);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(48, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1072, 136);
      this.panel1.TabIndex = 3;
      // 
      // lblVisualizedName
      // 
      this.lblVisualizedName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblVisualizedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVisualizedName.Location = new System.Drawing.Point(200, 0);
      this.lblVisualizedName.Name = "lblVisualizedName";
      this.lblVisualizedName.Size = new System.Drawing.Size(672, 136);
      this.lblVisualizedName.TabIndex = 0;
      this.lblVisualizedName.Text = "-";
      this.lblVisualizedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.chkIncludeDominant);
      this.panel4.Controls.Add(this.chkIncludeMinor);
      this.panel4.Controls.Add(this.chkIncludeMajor);
      this.panel4.Controls.Add(this.lblAuto);
      this.panel4.Controls.Add(this.lblBPM);
      this.panel4.Controls.Add(this.trackBPM);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(200, 136);
      this.panel4.TabIndex = 1;
      // 
      // chkIncludeDominant
      // 
      this.chkIncludeDominant.Checked = false;
      this.chkIncludeDominant.Location = new System.Drawing.Point(112, 8);
      this.chkIncludeDominant.Name = "chkIncludeDominant";
      this.chkIncludeDominant.Size = new System.Drawing.Size(64, 16);
      this.chkIncludeDominant.TabIndex = 8;
      this.chkIncludeDominant.Text = "Dominant";
      // 
      // chkIncludeMinor
      // 
      this.chkIncludeMinor.Checked = false;
      this.chkIncludeMinor.Location = new System.Drawing.Point(64, 8);
      this.chkIncludeMinor.Name = "chkIncludeMinor";
      this.chkIncludeMinor.Size = new System.Drawing.Size(40, 16);
      this.chkIncludeMinor.TabIndex = 7;
      this.chkIncludeMinor.Text = "Minor";
      // 
      // chkIncludeMajor
      // 
      this.chkIncludeMajor.Checked = true;
      this.chkIncludeMajor.Location = new System.Drawing.Point(16, 8);
      this.chkIncludeMajor.Name = "chkIncludeMajor";
      this.chkIncludeMajor.Size = new System.Drawing.Size(40, 16);
      this.chkIncludeMajor.TabIndex = 6;
      this.chkIncludeMajor.Text = "Major";
      // 
      // lblAuto
      // 
      this.lblAuto.AutoSize = true;
      this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAuto.Location = new System.Drawing.Point(48, 48);
      this.lblAuto.Name = "lblAuto";
      this.lblAuto.Size = new System.Drawing.Size(98, 36);
      this.lblAuto.TabIndex = 5;
      this.lblAuto.Text = "AUTO";
      this.lblAuto.Visible = false;
      // 
      // lblBPM
      // 
      this.lblBPM.AutoSize = true;
      this.lblBPM.Location = new System.Drawing.Point(8, 96);
      this.lblBPM.Name = "lblBPM";
      this.lblBPM.Size = new System.Drawing.Size(36, 13);
      this.lblBPM.TabIndex = 4;
      this.lblBPM.Text = "6 bpm";
      // 
      // trackBPM
      // 
      this.trackBPM.AutoSize = false;
      this.trackBPM.Location = new System.Drawing.Point(8, 112);
      this.trackBPM.Maximum = 60;
      this.trackBPM.Minimum = 1;
      this.trackBPM.Name = "trackBPM";
      this.trackBPM.Size = new System.Drawing.Size(184, 16);
      this.trackBPM.TabIndex = 3;
      this.trackBPM.TickFrequency = 12;
      this.trackBPM.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trackBPM.Value = 6;
      this.trackBPM.ValueChanged += new System.EventHandler(this.trackBPM_ValueChanged);
      // 
      // panel5
      // 
      this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel5.Location = new System.Drawing.Point(872, 0);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(200, 136);
      this.panel5.TabIndex = 2;
      // 
      // lstChords
      // 
      this.lstChords.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstChords.FormattingEnabled = true;
      this.lstChords.Location = new System.Drawing.Point(0, 16);
      this.lstChords.Name = "lstChords";
      this.lstChords.Size = new System.Drawing.Size(48, 664);
      this.lstChords.TabIndex = 0;
      this.lstChords.SelectedIndexChanged += new System.EventHandler(this.lstChords_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "Chords";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lstChords);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(48, 680);
      this.panel2.TabIndex = 4;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.lstScales);
      this.panel3.Controls.Add(this.label2);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel3.Location = new System.Drawing.Point(1120, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(54, 680);
      this.panel3.TabIndex = 5;
      // 
      // lstScales
      // 
      this.lstScales.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstScales.FormattingEnabled = true;
      this.lstScales.Location = new System.Drawing.Point(0, 16);
      this.lstScales.Name = "lstScales";
      this.lstScales.Size = new System.Drawing.Size(54, 664);
      this.lstScales.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Scales";
      // 
      // autoVisualizer
      // 
      this.autoVisualizer.Tick += new System.EventHandler(this.autoVisualizer_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1174, 680);
      this.Controls.Add(this.fretboardVisualizer1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
      this.panel1.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBPM)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private FretboardVisualizer fretboardVisualizer1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lstChords;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.ListBox lstScales;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblVisualizedName;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Timer autoVisualizer;
    private System.Windows.Forms.Label lblBPM;
    private System.Windows.Forms.TrackBar trackBPM;
    private System.Windows.Forms.Label lblAuto;
    private LabelCheckbox chkIncludeDominant;
    private LabelCheckbox chkIncludeMinor;
    private LabelCheckbox chkIncludeMajor;
  }
}

