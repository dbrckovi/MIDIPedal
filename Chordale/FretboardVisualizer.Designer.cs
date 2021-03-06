namespace Chordale
{
  partial class FretboardVisualizer
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
      this.components = new System.ComponentModel.Container();
      this.visualizationWaitTimer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // visualizationWaitTimer
      // 
      this.visualizationWaitTimer.Tick += new System.EventHandler(this.visualizationWaitTimer_Tick);
      // 
      // FretboardVisualizer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.DoubleBuffered = true;
      this.Name = "FretboardVisualizer";
      this.Size = new System.Drawing.Size(1075, 721);
      this.SizeChanged += new System.EventHandler(this.FretboardVisualizer_SizeChanged);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.FretboardVisualizer_Paint);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer visualizationWaitTimer;
  }
}
