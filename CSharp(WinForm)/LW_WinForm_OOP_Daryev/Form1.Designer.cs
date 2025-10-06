using LW_Draw;
namespace LW_WinForm_OOP_Daryev
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
      
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            systemMenuStrip = new MenuStrip();
            fileStripMenuIt = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            windowStripMenuIt = new ToolStripMenuItem();
            infoStripMenuIt = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            RectangleTool = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            mainPicture = new PictureBox();
            systemMenuStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPicture).BeginInit();
            SuspendLayout();
            // 
            // systemMenuStrip
            // 
            systemMenuStrip.BackColor = Color.White;
            systemMenuStrip.Items.AddRange(new ToolStripItem[] { fileStripMenuIt, windowStripMenuIt, infoStripMenuIt });
            systemMenuStrip.Location = new Point(0, 0);
            systemMenuStrip.Name = "systemMenuStrip";
            systemMenuStrip.Size = new Size(1904, 24);
            systemMenuStrip.TabIndex = 0;
            // 
            // fileStripMenuIt
            // 
            fileStripMenuIt.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileStripMenuIt.Name = "fileStripMenuIt";
            fileStripMenuIt.Size = new Size(37, 20);
            fileStripMenuIt.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // windowStripMenuIt
            // 
            windowStripMenuIt.Name = "windowStripMenuIt";
            windowStripMenuIt.Size = new Size(63, 20);
            windowStripMenuIt.Text = "Window";
            // 
            // infoStripMenuIt
            // 
            infoStripMenuIt.Name = "infoStripMenuIt";
            infoStripMenuIt.Size = new Size(40, 20);
            infoStripMenuIt.Text = "Info";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(180, 222, 189);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { RectangleTool, toolStripButton2 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(64, 1017);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // RectangleTool
            // 
            RectangleTool.Checked = true;
            RectangleTool.CheckState = CheckState.Checked;
            RectangleTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RectangleTool.Image = (Image)resources.GetObject("RectangleTool.Image");
            RectangleTool.ImageTransparentColor = Color.Magenta;
            RectangleTool.Name = "RectangleTool";
            RectangleTool.Size = new Size(61, 19);
            RectangleTool.Text = "Rectangle";
            RectangleTool.Click += RectangleTool_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(61, 19);
            toolStripButton2.Text = "Line";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // mainPicture
            // 
            mainPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPicture.BackColor = Color.White;
            mainPicture.Location = new Point(100, 44);
            mainPicture.Name = "mainPicture";
            mainPicture.Size = new Size(1458, 973);
            mainPicture.TabIndex = 2;
            mainPicture.TabStop = false;
            mainPicture.Paint += mainPicture_Paint;
            mainPicture.MouseDown += mainPicture_MouseDown;
            mainPicture.MouseMove += mainPicture_MouseMove;
            mainPicture.MouseUp += mainPicture_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 161, 186);
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainPicture);
            Controls.Add(toolStrip1);
            Controls.Add(systemMenuStrip);
            MainMenuStrip = systemMenuStrip;
            Name = "MainForm";
            Text = "LW_WinForm";
            WindowState = FormWindowState.Maximized;
            SizeChanged += MainForm_SizeChanged;
            systemMenuStrip.ResumeLayout(false);
            systemMenuStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip systemMenuStrip;
        private ToolStripMenuItem fileStripMenuIt;
        private ToolStripMenuItem windowStripMenuIt;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem infoStripMenuIt;
        private ToolStrip toolStrip1;
        private ToolStripButton RectangleTool;
        private ToolStripButton toolStripButton2;
        private PictureBox mainPicture;
    }
}
