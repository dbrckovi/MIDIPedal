namespace Chordale
{
  partial class LabelCheckbox
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblText = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblText
      // 
      this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblText.ForeColor = System.Drawing.Color.Gray;
      this.lblText.Location = new System.Drawing.Point(0, 0);
      this.lblText.Name = "lblText";
      this.lblText.Size = new System.Drawing.Size(78, 21);
      this.lblText.TabIndex = 0;
      this.lblText.Text = "-";
      this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblText.Click += new System.EventHandler(this.lblText_Click);
      // 
      // LabelCheckbox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblText);
      this.Name = "LabelCheckbox";
      this.Size = new System.Drawing.Size(78, 21);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblText;
  }
}
