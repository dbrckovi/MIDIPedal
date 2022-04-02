using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Chordale
{
  public partial class FretboardVisualizer : UserControl
  {
    private Visualizable _visualizableElement = null;
    private Pen _stringPen = new Pen(Color.DarkGray, 2);
    private Pen _fretMarkerPen = new Pen(Color.LightGray, 2);
    private Pen _fretPen = new Pen(Color.DarkGray, 2);
    private Pen _zeroFretPen = new Pen(Color.Black, 4);
    private Matrix _matrix = new Matrix();
    private float _zoom = 1f;
    private float _stringDistance = 30;
    private float _fretDistance = 40;
    private bool _drawNegative = false;
    private Font _noteFont = new Font("Arial", 12, FontStyle.Bold);
    private Color _chordNoteColor = Color.Brown;
    private bool _drawFretMarkers = true;

    public float Zoom
    {
      get { return _zoom; }
      set
      {
        _zoom = value;
        Redraw();
      }
    }

    public FretboardVisualizer()
    {
      InitializeComponent();
      this.MouseWheel += FretboardVisualizer_MouseWheel;
    }

    private void FretboardVisualizer_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta > 0 && Zoom < 8)
      {
        Zoom += 0.1f;
      }
      else if (e.Delta < 0 && Zoom > 0.1f)
      {
        Zoom -= 0.1f;
      }
    }

    public void VisualizeChord(Chord chord)
    {
      _drawNegative = false;
      _visualizableElement = chord;
      _drawFretMarkers = true;
      Redraw();
    }

    private void Redraw()
    {
      _matrix = new Matrix();
      int horizontalOffset = _drawNegative ? this.Width / 2 : this.Width / 4;

      _matrix.Translate(horizontalOffset, (this.Height / 2) - 2.5f * _stringDistance * _zoom);
      _matrix.Scale(_zoom, _zoom);

      this.Refresh();
    }

    private void FretboardVisualizer_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;

      g.Clear(this.BackColor);
      g.MultiplyTransform(_matrix);

      //strings
      float stringStartPoint = _drawNegative ? -12 * _fretDistance : 0;
      for (int y = 0; y < 6; y++)
      {
        g.DrawLine(_stringPen, stringStartPoint, y * _stringDistance, 12 * _fretDistance, y * _stringDistance);
      }

      //frets
      int firstFret = _drawNegative ? -12 : 0;
      for (int x = firstFret; x <= 12; x++)
      {
        Pen currentPen = x == 0 ? _zeroFretPen : _fretPen;
        g.DrawLine(currentPen, x * _fretDistance, 0, x * _fretDistance, 5 * _stringDistance);
      }

      //fret markers
      if (_drawFretMarkers)
      {
        DrawFretMarker(g, 3);
        DrawFretMarker(g, 5);
        DrawFretMarker(g, 7);
        DrawFretMarker(g, 9);
        DrawDoubleFretMarker(g, 12);

        if (_drawNegative)
        {
          DrawFretMarker(g, -3);
          DrawFretMarker(g, -5);
          DrawFretMarker(g, -7);
          DrawFretMarker(g, -9);
          DrawDoubleFretMarker(g, 0);
        }
      }

      //visualizable element
      if (_visualizableElement != null)
      {
        if (_visualizableElement is Chord) PaintChord(g, (Chord)_visualizableElement);
      }
    }

    private void DrawFretMarker(Graphics g, int fret)
    {
      float centerX = _fretDistance * fret - (_fretDistance / 2);
      float centerY = 2.5f * _stringDistance;
      float radius = GetNoteRadius() * 0.7f;
      RectangleF rect = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
      g.FillEllipse(new SolidBrush(_fretMarkerPen.Color), rect);
    }

    private void DrawDoubleFretMarker(Graphics g, int fret)
    {
      float centerX = _fretDistance * fret - (_fretDistance / 2);
      float centerY1 = 1.5f * _stringDistance;
      float centerY2 = 3.5f * _stringDistance;
      float radius = GetNoteRadius() * 0.7f;
      RectangleF rect1 = new RectangleF(centerX - radius, centerY1 - radius, radius * 2, radius * 2);
      RectangleF rect2 = new RectangleF(centerX - radius, centerY2 - radius, radius * 2, radius * 2);

      g.FillEllipse(new SolidBrush(_fretMarkerPen.Color), rect1);
      g.FillEllipse(new SolidBrush(_fretMarkerPen.Color), rect2);
    }

    private void PaintChord(Graphics g, Chord chord)
    {
      foreach (KeyValuePair<StringName, int> pair in chord.StringState)
      {
        if (pair.Value > 0) DrawNoteCircle(g, _chordNoteColor, pair.Value, pair.Key);
        else if (pair.Value == 0) DrawOpenFretNote(g, pair.Key);
        else DrawMutedString(g, pair.Key);
      }
    }

    private PointF GetNoteCenter(int fret, StringName guitarString)
    {
      float centerX = _fretDistance * fret - (_fretDistance / 2);
      float centerY = (int)guitarString * _stringDistance;
      return new PointF(centerX, centerY);
    }

    private float GetNoteRadius()
    {
      float radius = _fretDistance > _stringDistance ? _stringDistance : _fretDistance;
      radius *= 0.4f;
      return radius;
    }

    /// <summary>
    /// Draws note circle on the specified fret and string
    /// </summary>
    /// <param name="g">Graphics object used for drawing</param>
    /// <param name="color">Color of the circle</param>
    /// <param name="fret">Fret number (1-11)</param>
    /// <param name="guitarString">String on which the note circle will be drawn</param>
    private void DrawNoteCircle(Graphics g, Color color, int fret, StringName guitarString)
    {
      PointF center = GetNoteCenter(fret, guitarString);
      float radius = GetNoteRadius();
      RectangleF rect = new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);

      g.FillEllipse(new SolidBrush(color), rect);
      g.DrawEllipse(_stringPen, rect);
    }

    private void DrawNoteText(Graphics g, Color color, int fret, StringName guitarString, string text)
    {
      PointF center = GetNoteCenter(fret, guitarString);
      SizeF textSize = g.MeasureString(text, _noteFont);

      RectangleF rect = new RectangleF(center.X - textSize.Width / 2, center.Y - textSize.Height / 2, textSize.Width, textSize.Height);

      g.DrawString(text, _noteFont, new SolidBrush(color), rect);
    }

    private void DrawOpenFretNote(Graphics g, StringName guitarString)
    {
      DrawNoteCircle(g, this.BackColor, 0, guitarString);
    }

    private void DrawMutedString(Graphics g, StringName guitarString)
    {
      PointF center = GetNoteCenter(0, guitarString);
      float radius = GetNoteRadius();

      g.DrawLine(_stringPen, center.X - radius, center.Y - radius, center.X + radius, center.Y + radius);
      g.DrawLine(_stringPen, center.X - radius, center.Y + radius, center.X + radius, center.Y - radius);
    }

    private void FretboardVisualizer_SizeChanged(object sender, EventArgs e)
    {
      Redraw();
    }
  }
}
