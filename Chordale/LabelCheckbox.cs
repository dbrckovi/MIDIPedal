using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chordale
{
  public partial class LabelCheckbox : UserControl
  {
    private Color _falseColor = Color.Gray;
    private Color _trueColor = Color.Blue;
    private bool _checked = false;

    public bool Checked
    {
      get { return _checked; }
      set 
      { 
        _checked = value;
        lblText.ForeColor = _checked ? _trueColor : _falseColor;
      }
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override string Text
    {
      get { return lblText.Text; }
      set { lblText.Text = value; }
    }

    public LabelCheckbox()
    {
      InitializeComponent();
    }

    private void lblText_Click(object sender, EventArgs e)
    {
      Checked = !Checked;
    }
  }
}
