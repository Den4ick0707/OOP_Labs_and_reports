using LW_Daryev_WinForm_NewEdition.Draw;
using LW_Daryev_WinForm_NewEdition.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_Daryev_WinForm_NewEdition
{
    public partial class MainForm
    {
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            SetControlsLS();
        }
        private void openFileTSMI_Click(object sender, EventArgs e)
        {
            mainPicture.Image = FileManager.LoadFromFile();
        }
        private void saveAsTSMI_Click(object sender, EventArgs e)
        {
            if (mainPicture.Image == null)
                return;

            FileManager.SaveAsToFile((mainPicture.Image as Bitmap));
        }
        private void rectDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.RECTANGLE;
            ShowDrModeOnStatusStrip(MyDrawMode.RECTANGLE.ToString());
        }

        private void lineDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.LINE;
            ShowDrModeOnStatusStrip(MyDrawMode.LINE.ToString());

        }

        private void tianDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.TRIANGLE;
            ShowDrModeOnStatusStrip(MyDrawMode.TRIANGLE.ToString());

        }

        private void ellipseDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.ELLIPSE;
            ShowDrModeOnStatusStrip(MyDrawMode.ELLIPSE.ToString());

        }

        private void circleDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.CIRCLE;
            ShowDrModeOnStatusStrip(MyDrawMode.CIRCLE.ToString());

        }

        private void brushDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.BRUSH;
            ShowDrModeOnStatusStrip(MyDrawMode.BRUSH.ToString());

        }

        private void erraseToolTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.ERRASER;
            ShowDrModeOnStatusStrip(MyDrawMode.ERRASER.ToString());

        }

    }
}
