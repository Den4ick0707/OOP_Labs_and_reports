using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW_Daryev_WinForm_NewEdition.Brush;
using LW_Daryev_WinForm_NewEdition.Shape;

namespace LW_Daryev_WinForm_NewEdition.Draw
{
    public enum MyDrawMode
    {
        NONE,
        LINE,
        RECTANGLE,
        TRIANGLE,
        ELLIPSE,
        CIRCLE,
        BRUSH,
        ERRASER
    }
    public class UserCanvas
    {
        public Bitmap CanvasSourse { get; set; }
        public List<IShapeDraw> ShapesList;
        public List<IBrushDraw> BrushList;
        public bool IsDrawing { get; set; }
        public MyDrawMode DrMode { get; set; }
        public UserCanvas(Bitmap bmpSource)
        {
            CanvasSourse = bmpSource;
            ShapesList = new List<IShapeDraw>();
            BrushList = new List<IBrushDraw>();
            IsDrawing = false;
            DrMode = MyDrawMode.NONE;
        }

        public void ClearCanvas()
        {
            ShapesList.Clear();
            // BrushList.Clear();
            using (Graphics g = Graphics.FromImage(CanvasSourse))
            {
                g.Clear(Color.White);
            }
        }
        public void DrawAll()
        {
            foreach (var shape in ShapesList)
            {
                shape.DrawShape(CanvasSourse);
            }
            foreach (var brush in BrushList)
            {
                brush.DrawBrush(CanvasSourse);
            }

        }
        public void DrawPreviewShape(Graphics graphics)
        {
            foreach (var shape in ShapesList)
            {
                if (shape == ShapesList.Last())
                {
                    shape.DrawShape(graphics);
                }
            }
            foreach (var brush in BrushList)
            {
                if (brush == BrushList.Last())
                {
                    brush.DrawBrush(graphics);
                }
            }
        }
    }
}
