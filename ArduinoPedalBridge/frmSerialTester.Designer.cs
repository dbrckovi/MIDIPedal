
namespace ArduinoPedalBridge
{
  partial class frmSerialTester
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.progressLastByte = new System.Windows.Forms.ProgressBar();
      this.lblLastByte = new System.Windows.Forms.Label();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtIncomming = new System.Windows.Forms.RichTextBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.progressLastByte);
      this.panel1.Controls.Add(this.lblLastByte);
      this.panel1.Controls.Add(this.btnClear);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(3);
      this.panel1.Size = new System.Drawing.Size(625, 40);
      this.panel1.TabIndex = 0;
      // 
      // progressLastByte
      // 
      this.progressLastByte.Location = new System.Drawing.Point(240, 8);
      this.progressLastByte.MarqueeAnimationSpeed = 0;
      this.progressLastByte.Maximum = 255;
      this.progressLastByte.Name = "progressLastByte";
      this.progressLastByte.Size = new System.Drawing.Size(248, 24);
      this.progressLastByte.TabIndex = 2;
      // 
      // lblLastByte
      // 
      this.lblLastByte.AutoSize = true;
      this.lblLastByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastByte.Location = new System.Drawing.Point(16, 8);
      this.lblLastByte.Name = "lblLastByte";
      this.lblLastByte.Size = new System.Drawing.Size(19, 20);
      this.lblLastByte.TabIndex = 1;
      this.lblLastByte.Text = "0";
      // 
      // btnClear
      // 
      this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnClear.Location = new System.Drawing.Point(502, 3);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(120, 34);
      this.btnClear.TabIndex = 0;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // txtIncomming
      // 
      this.txtIncomming.BackColor = System.Drawing.Color.White;
      this.txtIncomming.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtIncomming.Location = new System.Drawing.Point(0, 40);
      this.txtIncomming.Name = "txtIncomming";
      this.txtIncomming.ReadOnly = true;
      this.txtIncomming.Size = new System.Drawing.Size(625, 381);
      this.txtIncomming.TabIndex = 1;
      this.txtIncomming.Text = "";
      // 
      // frmSerialTester
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(625, 421);
      this.Controls.Add(this.txtIncomming);
      this.Controls.Add(this.panel1);
      this.Name = "frmSerialTester";
      this.Text = "frmSerialTester";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSerialTester_FormClosed);
      this.Load += new System.EventHandler(this.frmSerialTester_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.RichTextBox txtIncomming;
    private System.Windows.Forms.Label lblLastByte;
    private System.Windows.Forms.ProgressBar progressLastByte;
  }
}