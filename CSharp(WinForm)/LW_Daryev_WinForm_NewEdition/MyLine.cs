using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW_Daryev_WinForm_NewEdition.Draw;


namespace LW_Daryev_WinForm_NewEdition.Shape
{
    internal class MyLine : IShapeDraw
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color ShapeColor { get; set; }
        public float ShapeSize { get; set; }
        public MyLine(Point startPoint, Point endPoint, Color shapeColor, float shapeSize)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            ShapeColor = shapeColor;
            ShapeSize = shapeSize;
        }
        public void DrawShape(Bitmap bmp)
        {
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                using (Pen pen = new Pen(ShapeColor, ShapeSize))
                {
                    graphics.DrawLine(pen, StartPoint, EndPoint);
                }
            }
        }
        public void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(ShapeColor, ShapeSize))
            {
                graphics.DrawLine(pen, StartPoint, EndPoint);
            }
        }
    }
}
