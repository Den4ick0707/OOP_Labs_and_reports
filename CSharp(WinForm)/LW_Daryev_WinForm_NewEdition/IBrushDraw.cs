using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_Daryev_WinForm_NewEdition.Brush
{
    public interface IBrushDraw
    {
        public Point[] Position { get; set; }
        public Color BrushColor { get; set; }
        public float BrushSize { get; set; }
        public void AddPosition(Point position);
        public void DrawBrush(Bitmap bmp);
        public void DrawBrush(Graphics graphics);
    }
}
