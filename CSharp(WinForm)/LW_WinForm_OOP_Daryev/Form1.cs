using LW_Draw;

namespace LW_WinForm_OOP_Daryev
{
    public enum DrawMode
    {
        None,
        Line,
        Rectangle
    }
    public partial class MainForm : Form
    {
        public static Bitmap mainBMP;
        private DrawMode dm;
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;

        public MainForm()
        {
            InitializeComponent();

            
            mainPicture.Size = NormaliseMachine.DenormaliseSize(mainPicture, this, new SizeF(0.8f, 0.9f));
            mainPicture.Location = NormaliseMachine.DenormalisePoint(mainPicture, this, new PointF(0.05f, 0.05f));

            dm = DrawMode.None;
            mainBMP = new Bitmap(mainPicture.Width, mainPicture.Height);

            mainPicture.Image = mainBMP;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            mainPicture.Size = NormaliseMachine.DenormaliseSize(mainPicture, this, new SizeF(0.8f, 0.9f));
            mainPicture.Location = NormaliseMachine.DenormalisePoint(mainPicture, this, new PointF(0.05f, 0.05f));
            mainBMP = new Bitmap(mainPicture.Width, mainPicture.Height);
            mainPicture.Image = mainBMP;
        }

        private void mainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (dm == DrawMode.None) return;

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

            Figure fig = null;
            switch (dm)
            {
                case DrawMode.Line:
                    fig = new MyLine(startPoint, endPoint);
                    break;
                case DrawMode.Rectangle:
                    fig = new MyRectangle(startPoint, endPoint);
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
                case DrawMode.Line:
                    e.Graphics.DrawLine(Pens.Red, startPoint, endPoint);
                    break;
                case DrawMode.Rectangle:
                    e.Graphics.DrawRectangle(Pens.Red,
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Abs(endPoint.X - startPoint.X),
                        Math.Abs(endPoint.Y - startPoint.Y));
                    break;
            }
        }

        private void RectangleTool_Click(object sender, EventArgs e)
        {
            dm = DrawMode.Rectangle;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dm = DrawMode.Line;
        }
    }

}
