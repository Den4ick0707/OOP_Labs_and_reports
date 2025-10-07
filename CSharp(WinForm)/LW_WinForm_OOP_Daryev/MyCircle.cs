using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW_User_Draw;

namespace LW_WinForm_OOP_Daryev
{
    public class MyCircle: IFigureDraw
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public MyCircle(Point s, Point e)
        {
            startPoint = s;
            endPoint = e;
        }

        public void DrawFigure(Bitmap bmp)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                int radius = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
                g.DrawEllipse(Pens.Black,
                    startPoint.X - radius,
                    startPoint.Y - radius,
                    radius * 2,
                    radius * 2);
            }
        }
    }
}
