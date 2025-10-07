using LW_Draw;
using LW_User_Draw;

namespace LW_WinForm_OOP_Daryev
{
    public partial class MainForm : Form
    {
        public Bitmap mainBMP;
        private UserDrawMode dm;
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        public MainForm()
        {
            InitializeComponent();
            mainPicture.Size = NormaliseMachine.DenormaliseSize(mainPicture, this, new SizeF(0.8f, 0.9f));
            mainPicture.Location = NormaliseMachine.DenormalisePoint(mainPicture, this, new PointF(0.05f, 0.05f));

            dm = UserDrawMode.None;
            mainBMP = new Bitmap(mainPicture.Width, mainPicture.Height);
            mainPicture.Image = mainBMP;
        }
    }
}
