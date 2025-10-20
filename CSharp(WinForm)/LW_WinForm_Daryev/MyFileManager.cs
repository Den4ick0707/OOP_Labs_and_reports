
namespace LW_WinForm_Daryev.FileMahager
{
    public static class MyFileManager
    {
       
        public static Bitmap? LoadFromFile()
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|All files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return new Bitmap(ofd.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot open this file as a image.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return null;
        }

        public static void SaveAsToFile(Bitmap bmp)
        {
            if (bmp == null)
                throw new ArgumentNullException(nameof(bmp));

            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bmp.Save(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save file error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}