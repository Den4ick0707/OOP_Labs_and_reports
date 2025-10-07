using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW_User_Draw;

namespace LW_WinForm_OOP_Daryev
{
    public class MyElipse : IFigureDraw
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public MyElipse(Point s, Point e)
        {
            startPoint = s;
            endPoint = e;
        }

        public void DrawFigure(Bitmap bmp)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawEllipse(Pens.Black,
                       Math.Min(startPoint.X, endPoint.X),
                       Math.Min(startPoint.Y, endPoint.Y),
                       Math.Abs(endPoint.X - startPoint.X),
                       Math.Abs(endPoint.Y - startPoint.Y));
            }
        }
    }
}
