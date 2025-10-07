using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_User_Draw
{
    public enum UserDrawMode
    {
        None,
        Line,
        Rectangle,
        Elipse,
        Circle
    }
    public interface IFigureDraw
    {
        public void DrawFigure(Bitmap bmp);
    }
}
