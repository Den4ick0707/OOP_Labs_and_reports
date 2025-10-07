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
            LineDrawTool = new ToolStripButton();
            RectangleDrawTool = new ToolStripButton();
            ElipseDrawTool = new ToolStripButton();
            CircleDrawTool = new ToolStripButton();
            mainPicture = new PictureBox();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
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
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // windowStripMenuIt
            // 
            windowStripMenuIt.Name = "windowStripMenuIt";
            windowStripMenuIt.Size = new Size(63, 20);
            windowStripMenuIt.Text = "Window";
            // 
            // infoStripMenuIt
            // 
            infoStripMenuIt.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2, toolStripTextBox3 });
            infoStripMenuIt.Name = "infoStripMenuIt";
            infoStripMenuIt.Size = new Size(40, 20);
            infoStripMenuIt.Text = "Info";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(180, 222, 189);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { LineDrawTool, RectangleDrawTool, ElipseDrawTool, CircleDrawTool });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(64, 1017);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // LineDrawTool
            // 
            LineDrawTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LineDrawTool.Image = (Image)resources.GetObject("LineDrawTool.Image");
            LineDrawTool.ImageTransparentColor = Color.Magenta;
            LineDrawTool.Name = "LineDrawTool";
            LineDrawTool.Size = new Size(61, 19);
            LineDrawTool.Text = "Line";
            LineDrawTool.Click += toolStripButton2_Click;
            // 
            // RectangleDrawTool
            // 
            RectangleDrawTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RectangleDrawTool.Image = (Image)resources.GetObject("RectangleDrawTool.Image");
            RectangleDrawTool.ImageTransparentColor = Color.Magenta;
            RectangleDrawTool.Name = "RectangleDrawTool";
            RectangleDrawTool.Size = new Size(61, 19);
            RectangleDrawTool.Text = "Rectangle";
            RectangleDrawTool.Click += RectangleTool_Click;
            // 
            // ElipseDrawTool
            // 
            ElipseDrawTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ElipseDrawTool.Image = (Image)resources.GetObject("ElipseDrawTool.Image");
            ElipseDrawTool.ImageTransparentColor = Color.Magenta;
            ElipseDrawTool.Name = "ElipseDrawTool";
            ElipseDrawTool.Size = new Size(61, 19);
            ElipseDrawTool.Text = "Elipse";
            ElipseDrawTool.Click += toolStripButton1_Click;
            // 
            // CircleDrawTool
            // 
            CircleDrawTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            CircleDrawTool.Image = (Image)resources.GetObject("CircleDrawTool.Image");
            CircleDrawTool.ImageTransparentColor = Color.Magenta;
            CircleDrawTool.Name = "CircleDrawTool";
            CircleDrawTool.Size = new Size(61, 19);
            CircleDrawTool.Text = "Circle";
            CircleDrawTool.Click += CircleDrawTool_Click;
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
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Segoe UI", 12F);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(200, 29);
            toolStripTextBox1.Text = "Programmer:";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Font = new Font("Segoe UI", 12F);
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new Size(200, 29);
            toolStripTextBox2.Text = "Student group PI-231";
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.ReadOnly = true;
            toolStripTextBox3.Size = new Size(200, 29);
            toolStripTextBox3.Text = "Daryev Daniil";
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
        private ToolStripButton RectangleDrawTool;
        private ToolStripButton LineDrawTool;
        private PictureBox mainPicture;
        private ToolStripButton ElipseDrawTool;
        private ToolStripButton CircleDrawTool;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
    }
}
