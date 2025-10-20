using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW_Daryev_WinForm_NewEdition.Draw;

namespace LW_Daryev_WinForm_NewEdition.Shape
{
    public class MyCircle : IShapeDraw
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color ShapeColor { get; set; }
        public float ShapeSize { get; set; }
        public MyCircle(Point startPoint, Point endPoint, Color shapeColor, float shapeSize)
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
                int x = Math.Min(StartPoint.X, EndPoint.X);
                int y = Math.Min(StartPoint.Y, EndPoint.Y);
                int diameter = Math.Max(Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y));
                graphics.DrawEllipse(pen, x, y, diameter, diameter);
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
