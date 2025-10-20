using LW_Daryev_WinForm_NewEdition.Draw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_Daryev_WinForm_NewEdition.Shape
{
    internal class MyTriangle : IShapeDraw
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color ShapeColor { get; set; }
        public float ShapeSize { get; set; }
        public MyTriangle(Point startPoint, Point endPoint, Color shapeColor, float shapeSize)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            ShapeColor = shapeColor;
            ShapeSize = shapeSize;
        }
        private void DrawOnly(Graphics graphics)
        {
            using (Pen pen = new Pen(ShapeColor, ShapeSize))
            {
                Point point1 = new Point((StartPoint.X + EndPoint.X) / 2, StartPoint.Y);
                Point point2 = new Point(StartPoint.X, EndPoint.Y);
                Point point3 = new Point(EndPoint.X, EndPoint.Y);
                graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
            }
        }
        public void DrawShape(Bitmap bmp)
        {
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                DrawOnly(graphics);
            }
        }
        public void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(ShapeColor, ShapeSize))
            {
                DrawOnly(graphics);
            }
        }
    }
}
