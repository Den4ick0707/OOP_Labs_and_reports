
namespace LW_WinForm_Daryev
{
    partial class MainForm :Form
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
            mainMenuBar = new MenuStrip();
            fileMenuIT = new ToolStripMenuItem();
            openFile = new ToolStripMenuItem();
            saveFileAs = new ToolStripMenuItem();
            windowMenuIT = new ToolStripMenuItem();
            infoMenuIT = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolsToolStrip = new ToolStrip();
            drawRectTSSB = new ToolStripSplitButton();
            drawLineTSSB = new ToolStripSplitButton();
            drawTriangleTSSB = new ToolStripSplitButton();
            drawEllipseTSSB = new ToolStripSplitButton();
            drawCircleTSSB = new ToolStripSplitButton();
            drawBrushTSSB = new ToolStripSplitButton();
            erraseTSSB = new ToolStripSplitButton();
            mainCanvasPB = new PictureBox();
            mainMenuBar.SuspendLayout();
            toolsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainCanvasPB).BeginInit();
            SuspendLayout();
            // 
            // mainMenuBar
            // 
            mainMenuBar.AutoSize = false;
            mainMenuBar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenuBar.Items.AddRange(new ToolStripItem[] { fileMenuIT, windowMenuIT, infoMenuIT });
            mainMenuBar.Location = new Point(0, 0);
            mainMenuBar.Name = "mainMenuBar";
            mainMenuBar.Size = new Size(1029, 24);
            mainMenuBar.TabIndex = 0;
            // 
            // fileMenuIT
            // 
            fileMenuIT.DropDownItems.AddRange(new ToolStripItem[] { openFile, saveFileAs });
            fileMenuIT.Name = "fileMenuIT";
            fileMenuIT.Size = new Size(39, 20);
            fileMenuIT.Text = "File";
            // 
            // openFile
            // 
            openFile.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openFile.Name = "openFile";
            openFile.ShortcutKeys = Keys.Control | Keys.O;
            openFile.Size = new Size(178, 22);
            openFile.Text = "Open";
            // 
            // saveFileAs
            // 
            saveFileAs.Font = new Font("Arial", 11.25F);
            saveFileAs.Name = "saveFileAs";
            saveFileAs.ShortcutKeys = Keys.Control | Keys.S;
            saveFileAs.Size = new Size(178, 22);
            saveFileAs.Text = "Save as";
            // 
            // windowMenuIT
            // 
            windowMenuIT.Name = "windowMenuIT";
            windowMenuIT.Size = new Size(63, 20);
            windowMenuIT.Text = "Window";
            // 
            // infoMenuIT
            // 
            infoMenuIT.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            infoMenuIT.Name = "infoMenuIT";
            infoMenuIT.Size = new Size(39, 20);
            infoMenuIT.Text = "Info";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "DaryevDaniil";
            // 
            // toolsToolStrip
            // 
            toolsToolStrip.AutoSize = false;
            toolsToolStrip.BackColor = Color.FromArgb(245, 234, 116);
            toolsToolStrip.Dock = DockStyle.Left;
            toolsToolStrip.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolsToolStrip.GripMargin = new Padding(0);
            toolsToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolsToolStrip.Items.AddRange(new ToolStripItem[] { drawRectTSSB, drawLineTSSB, drawTriangleTSSB, drawEllipseTSSB, drawCircleTSSB, drawBrushTSSB, erraseTSSB });
            toolsToolStrip.Location = new Point(0, 24);
            toolsToolStrip.Name = "toolsToolStrip";
            toolsToolStrip.RightToLeft = RightToLeft.No;
            toolsToolStrip.Size = new Size(111, 516);
            toolsToolStrip.TabIndex = 1;
            // 
            // drawRectTSSB
            // 
            drawRectTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drawRectTSSB.Image = (Image)resources.GetObject("drawRectTSSB.Image");
            drawRectTSSB.ImageTransparentColor = Color.Magenta;
            drawRectTSSB.Name = "drawRectTSSB";
            drawRectTSSB.Size = new Size(109, 22);
            drawRectTSSB.Text = "Rectangle";
            // 
            // drawLineTSSB
            // 
            drawLineTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drawLineTSSB.Image = (Image)resources.GetObject("drawLineTSSB.Image");
            drawLineTSSB.ImageTransparentColor = Color.Magenta;
            drawLineTSSB.Name = "drawLineTSSB";
            drawLineTSSB.Size = new Size(109, 22);
            drawLineTSSB.Text = "Line";
            // 
            // drawTriangleTSSB
            // 
            drawTriangleTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drawTriangleTSSB.Image = (Image)resources.GetObject("drawTriangleTSSB.Image");
            drawTriangleTSSB.ImageTransparentColor = Color.Magenta;
            drawTriangleTSSB.Name = "drawTriangleTSSB";
            drawTriangleTSSB.Size = new Size(109, 22);
            drawTriangleTSSB.Text = "Triangle";
            // 
            // drawEllipseTSSB
            // 
            drawEllipseTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drawEllipseTSSB.Image = (Image)resources.GetObject("drawEllipseTSSB.Image");
            drawEllipseTSSB.ImageTransparentColor = Color.Magenta;
            drawEllipseTSSB.Name = "drawEllipseTSSB";
            drawEllipseTSSB.Size = new Size(109, 22);
            drawEllipseTSSB.Text = "Ellipse";
            // 
            // drawCircleTSSB
            // 
            drawCircleTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drawCircleTSSB.Image = (Image)resources.GetObject("drawCircleTSSB.Image");
            drawCircleTSSB.ImageTransparentColor = Color.Magenta;
            drawCircleTSSB.Name = "drawCircleTSSB";
            drawCircleTSSB.Size = new Size(109, 22);
            drawCircleTSSB.Text = "Circle";
            // 
            // drawBrushTSSB
            // 
            drawBrushTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drawBrushTSSB.Image = (Image)resources.GetObject("drawBrushTSSB.Image");
            drawBrushTSSB.ImageTransparentColor = Color.Magenta;
            drawBrushTSSB.Name = "drawBrushTSSB";
            drawBrushTSSB.Size = new Size(109, 22);
            drawBrushTSSB.Text = "Brush";
            // 
            // erraseTSSB
            // 
            erraseTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            erraseTSSB.Image = (Image)resources.GetObject("erraseTSSB.Image");
            erraseTSSB.ImageTransparentColor = Color.Magenta;
            erraseTSSB.Name = "erraseTSSB";
            erraseTSSB.Size = new Size(109, 22);
            erraseTSSB.Text = "Erraser";
            // 
            // mainCanvasPB
            // 
            mainCanvasPB.BackColor = Color.White;
            mainCanvasPB.Location = new Point(127, 37);
            mainCanvasPB.Name = "mainCanvasPB";
            mainCanvasPB.Size = new Size(818, 464);
            mainCanvasPB.SizeMode = PictureBoxSizeMode.StretchImage;
            mainCanvasPB.TabIndex = 2;
            mainCanvasPB.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 157, 137);
            ClientSize = new Size(1029, 540);
            Controls.Add(mainCanvasPB);
            Controls.Add(toolsToolStrip);
            Controls.Add(mainMenuBar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mainMenuBar;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Windows Form";
            mainMenuBar.ResumeLayout(false);
            mainMenuBar.PerformLayout();
            toolsToolStrip.ResumeLayout(false);
            toolsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainCanvasPB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip mainMenuBar;
        private ToolStripMenuItem fileMenuIT;
        private ToolStripMenuItem windowMenuIT;
        private ToolStripMenuItem infoMenuIT;
        private ToolStripMenuItem openFile;
        private ToolStripMenuItem saveFileAs;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStrip toolsToolStrip;
        private ToolStripComboBox rectangleDrawTI;
        private ToolStripSplitButton drawTriangleTSSB;
        private ToolStripSplitButton drawRectTSSB;
        private ToolStripSplitButton drawLineTSSB;
        private ToolStripSplitButton drawEllipseTSSB;
        private ToolStripSplitButton drawCircleTSSB;
        private ToolStripSplitButton drawBrushTSSB;
        private ToolStripSplitButton erraseTSSB;
        private PictureBox mainCanvasPB;
    }
}
