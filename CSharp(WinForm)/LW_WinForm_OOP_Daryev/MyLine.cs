using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_WinForm_OOP_Daryev
{
    public class MyLine : Figure
    {
        public MyLine(Point s, Point e)
        {
            startPoint = s;
            endPoint = e;
        }

        public override void DrawFigure(Bitmap bmp)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLine(Pens.Black, startPoint, endPoint);
            }
        }
    }
}
