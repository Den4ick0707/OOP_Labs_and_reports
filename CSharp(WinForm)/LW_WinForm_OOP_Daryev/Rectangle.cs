using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LW_WinForm_OOP_Daryev;

namespace LW_WinForm_OOP_Daryev
{
    public class MyRectangle : Figure
    {
        public MyRectangle(Point s, Point e)
        {
            startPoint = s;
            endPoint = e;
        }
        public override void DrawFigure(Bitmap bmp)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawRectangle(Pens.Black,
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(endPoint.X - startPoint.X),
                    Math.Abs(endPoint.Y - startPoint.Y));
            }
        }
    }
}
