using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPedalBridge
{
  public partial class ButtonState : UserControl
  {
    SolidBrush _onBrush = new SolidBrush(Color.Lime);
    SolidBrush _offBrush;

    private bool _on = false;
    private int _index = 0;

    public bool On
    {
      get { return _on; }
      set
      {
        _on = value;
        Refresh();
      }
    }

    public int Index
    {
      get { return _index; }
      set 
      { 
        _index = value;
        Refresh();
      }
    }

    public ButtonState()
    {
      InitializeComponent();
      _offBrush = new SolidBrush(this.BackColor);
    }

    private void ButtonState_Paint(object sender, PaintEventArgs e)
    {
      Brush fillBrush = _on ? _onBrush : _offBrush;
      Rectangle rect = new Rectangle(0, 0, this.Width-1, this.Height-1);
      SizeF textSize = e.Graphics.MeasureString(_index.ToString(), this.Font);
      int textLeft = (int)(this.Width - textSize.Width) / 2;
      int textTop = (int)(this.Height - textSize.Height) / 2;

      e.Graphics.Clear(this.BackColor);
      e.Graphics.FillEllipse(fillBrush, rect);
      e.Graphics.DrawEllipse(Pens.Black, rect);
      e.Graphics.DrawString(_index.ToString(), this.Font, Brushes.Black, new Point(textLeft, textTop));
    }
  }
}
