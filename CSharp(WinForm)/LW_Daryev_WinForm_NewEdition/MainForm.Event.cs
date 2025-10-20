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
        }

        private void lineDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.LINE;
        }

        private void tianDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.TRIANGLE;
        }

        private void ellipseDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.ELLIPSE;
        }

        private void circleDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.CIRCLE;
        }

        private void brushDrawTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.BRUSH;
        }

        private void erraseToolTSSB_ButtonClick(object sender, EventArgs e)
        {
            CanvasOnMainForm.DrMode = MyDrawMode.ERRASER;
        }

    }
}
