using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_Files
{
    public static class MyFileManager
    {
        public static Bitmap LoadFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
                return new Bitmap(ofd.FileName);

            return  null;
        }
        public static void SaveAsToFile(Bitmap bmp)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
                bmp.Save(sfd.FileName);
        }
    }
}