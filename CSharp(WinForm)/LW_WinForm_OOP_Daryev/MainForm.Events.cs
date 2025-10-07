using LW_Draw;
using LW_User_Draw;
using LW_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_WinForm_OOP_Daryev
{
    public partial class MainForm
    {
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            mainPicture.Size = NormaliseMachine.DenormaliseSize(mainPicture, this, new SizeF(0.8f, 0.9f));
            mainPicture.Location = NormaliseMachine.DenormalisePoint(mainPicture, this, new PointF(0.05f, 0.05f));
            mainBMP = new Bitmap(mainPicture.Width, mainPicture.Height);
            mainPicture.Image = mainBMP;
        }
        private void mainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (dm == UserDrawMode.None) return;

            isDrawing = true;
            startPoint = e.Location;
            endPoint = e.Location;
        }
        private void mainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            endPoint = e.Location;
            mainPicture.Refresh();
        }
        private void mainPicture_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            endPoint = e.Location;

            IFigureDraw fig = null;
            switch (dm)
            {
                case UserDrawMode.Line:
                    fig = new MyLine(startPoint, endPoint);
                    break;
                case UserDrawMode.Rectangle:
                    fig = new MyRectangle(startPoint, endPoint);
                    break;
                case UserDrawMode.Elipse:
                    fig = new MyElipse(startPoint, endPoint);
                    break;
                case UserDrawMode.Circle:
                    fig = new MyCircle(startPoint, endPoint);
                    break;
            }

            fig?.DrawFigure(mainBMP);
            mainPicture.Image = mainBMP;
            mainPicture.Refresh();
        }
        private void mainPicture_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing) return;

            switch (dm)
            {
                case UserDrawMode.Line:
                    e.Graphics.DrawLine(Pens.Black, startPoint, endPoint);
                    break;
                case UserDrawMode.Rectangle:
                    e.Graphics.DrawRectangle(Pens.Black,
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Abs(endPoint.X - startPoint.X),
                        Math.Abs(endPoint.Y - startPoint.Y));
                    break;
                case UserDrawMode.Elipse:
                    e.Graphics.DrawEllipse(Pens.Black,
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Abs(endPoint.X - startPoint.X),
                        Math.Abs(endPoint.Y - startPoint.Y));
                    break;
                case UserDrawMode.Circle:
                    int radius = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
                    e.Graphics.DrawEllipse(Pens.Black,
                        startPoint.X - radius,
                        startPoint.Y - radius,
                        radius * 2,
                        radius * 2);
                    break;

            }
        }
        private void RectangleTool_Click(object sender, EventArgs e)
        {
            dm = UserDrawMode.Rectangle;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dm = UserDrawMode.Line;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dm = UserDrawMode.Elipse;
        }
        private void CircleDrawTool_Click(object sender, EventArgs e)
        {
            dm = UserDrawMode.Circle;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPicture.Image = MyFileManager.LoadFromFile();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyFileManager.SaveAsToFile(mainBMP);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyFileManager.SaveAsToFile(mainBMP);
        }
    }
}
