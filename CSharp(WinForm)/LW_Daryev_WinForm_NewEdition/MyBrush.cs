using LW_Daryev_WinForm_NewEdition.Brush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_Daryev_WinForm_NewEdition.Brush
{
    internal class MyBrush : IBrushDraw
    {
        public Point[] Position { get; set; }
        public Color BrushColor { get; set; }
        public float BrushSize { get; set; }
        public MyBrush(Point position, Color brushColor, float brushSize)
        {
            Position = new Point[0];
            Position = Position.Append(position).ToArray();
            BrushColor = brushColor;
            BrushSize = brushSize;
        }
        public void AddPosition(Point position)
        {
            if (Position.Length > 0)
            {
                Point last = Position[^1]; // остання точка
                                           // Додавання проміжних точок для плавності
                int dx = position.X - last.X;
                int dy = position.Y - last.Y;
                int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
                for (int i = 1; i <= steps; i++)
                {
                    int x = last.X + dx * i / steps;
                    int y = last.Y + dy * i / steps;
                    Position = Position.Append(new Point(x, y)).ToArray();
                }
            }
            else
            {
                Position = Position.Append(position).ToArray();
            }
        }

        public void DrawBrush(Bitmap bmp)
        {
            using (Graphics graphics = Graphics.FromImage(bmp))
            using (Pen pen = new Pen(BrushColor, BrushSize))
                for (int i = 1; i < Position.Length; i++)
                    graphics.DrawEllipse(pen, Position[i].X, Position[i].Y, BrushSize, BrushSize);

        }
        public void DrawBrush(Graphics graphics)
        {
            using (Pen pen = new Pen(BrushColor, BrushSize))
                for (int i = 1; i < Position.Length; i++)
                    graphics.DrawEllipse(pen, Position[i].X, Position[i].Y, BrushSize, BrushSize);
        }

    }
}
