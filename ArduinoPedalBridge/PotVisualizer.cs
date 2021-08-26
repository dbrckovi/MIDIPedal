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

  public partial class PotVisualizer : UserControl
  {
    private Pen _borderPen = Pens.DarkGray;
    private Brush _valueBrush = Brushes.Lime;

    private float _value = 0f;
    private bool _horizontal = false;

    public float Value
    {
      get { return _value; }
      set
      {
        if (value < 0f) _value = 0f;
        else if (value > 1f) _value = 1f;
        else _value = value;
        this.Refresh();
      }
    }

    public bool Horizontal
    {
      get { return _horizontal; }
      set
      {
        _horizontal = value;
        this.Refresh();
      }
    }

    public PotVisualizer()
    {
      InitializeComponent();
    }

    private void PotVisualizer_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.Clear(this.BackColor);
      e.Graphics.DrawRectangle(_borderPen, 0, 0, this.Width - 1, this.Height - 1);

      Rectangle valueRect = new Rectangle();

      if (_horizontal)
      {
        valueRect.X = 1;
        valueRect.Y = 1;
        valueRect.Height = this.Height - 2;
        valueRect.Width = Convert.ToInt32((this.Width - 2) * _value);
      }
      else //vertical
      {
        valueRect.X = 1;
        valueRect.Width = this.Width - 2;
        valueRect.Height = Convert.ToInt32((this.Height - 2) * _value);
        valueRect.Y = this.Height - 1 - valueRect.Height;
      }

      e.Graphics.FillRectangle(_valueBrush, valueRect);
    }
  }
}
