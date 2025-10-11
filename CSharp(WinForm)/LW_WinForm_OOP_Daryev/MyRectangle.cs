using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LW_WinForm_OOP_Daryev;
using LW_User_Draw;

namespace LW_User_Draw
{
    public class MyRectangle : IFigureDraw
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public MyRectangle(Point s, Point e)
        {
            startPoint = s;
            endPoint = e;
        }
        public void DrawFigure(Bitmap bmp)
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

    public class LW_UserDraw_MyRectangle
    {
    }
}
