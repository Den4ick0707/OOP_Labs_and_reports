namespace LW_Daryev_WinForm_NewEdition
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
            menuBarStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileTSMI = new ToolStripMenuItem();
            saveAsTSMI = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolsToolStrip = new ToolStrip();
            rectDrawTSSB = new ToolStripSplitButton();
            lineDrawTSSB = new ToolStripSplitButton();
            tianDrawTSSB = new ToolStripSplitButton();
            ellipseDrawTSSB = new ToolStripSplitButton();
            circleDrawTSSB = new ToolStripSplitButton();
            brushDrawTSSB = new ToolStripSplitButton();
            erraseToolTSSB = new ToolStripSplitButton();
            mainPicture = new PictureBox();
            propToolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            ColorInfoAndChangeToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            SizeToolStripComboBox = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel4 = new ToolStripLabel();
            toolStripLabel5 = new ToolStripLabel();
            StatusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            StatusModeStripValue = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            DrawingStatusShow = new ToolStripStatusLabel();
            menuBarStrip.SuspendLayout();
            toolsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPicture).BeginInit();
            propToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuBarStrip
            // 
            menuBarStrip.AutoSize = false;
            menuBarStrip.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuBarStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowToolStripMenuItem, infoToolStripMenuItem });
            menuBarStrip.Location = new Point(0, 0);
            menuBarStrip.Name = "menuBarStrip";
            menuBarStrip.Size = new Size(972, 24);
            menuBarStrip.TabIndex = 0;
            menuBarStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileTSMI, saveAsTSMI });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(40, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileTSMI
            // 
            openFileTSMI.Name = "openFileTSMI";
            openFileTSMI.ShortcutKeys = Keys.Control | Keys.O;
            openFileTSMI.Size = new Size(198, 22);
            openFileTSMI.Text = "Open";
            openFileTSMI.Click += openFileTSMI_Click;
            // 
            // saveAsTSMI
            // 
            saveAsTSMI.Name = "saveAsTSMI";
            saveAsTSMI.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsTSMI.Size = new Size(198, 22);
            saveAsTSMI.Text = "Save as";
            saveAsTSMI.Click += saveAsTSMI_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(65, 20);
            windowToolStripMenuItem.Text = "Window";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(39, 20);
            infoToolStripMenuItem.Text = "Info";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(160, 23);
            toolStripTextBox1.Text = "Created by Daryev Daniil";
            // 
            // toolsToolStrip
            // 
            toolsToolStrip.AutoSize = false;
            toolsToolStrip.BackColor = Color.FromArgb(255, 242, 123);
            toolsToolStrip.Dock = DockStyle.Left;
            toolsToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolsToolStrip.Items.AddRange(new ToolStripItem[] { rectDrawTSSB, lineDrawTSSB, tianDrawTSSB, ellipseDrawTSSB, circleDrawTSSB, brushDrawTSSB, erraseToolTSSB });
            toolsToolStrip.Location = new Point(0, 24);
            toolsToolStrip.Name = "toolsToolStrip";
            toolsToolStrip.Size = new Size(111, 539);
            toolsToolStrip.TabIndex = 1;
            // 
            // rectDrawTSSB
            // 
            rectDrawTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            rectDrawTSSB.Font = new Font("Arial", 12F);
            rectDrawTSSB.Image = (Image)resources.GetObject("rectDrawTSSB.Image");
            rectDrawTSSB.ImageTransparentColor = Color.Magenta;
            rectDrawTSSB.Name = "rectDrawTSSB";
            rectDrawTSSB.Size = new Size(109, 22);
            rectDrawTSSB.Text = "Rectangle";
            rectDrawTSSB.TextDirection = ToolStripTextDirection.Horizontal;
            rectDrawTSSB.ButtonClick += rectDrawTSSB_ButtonClick;
            // 
            // lineDrawTSSB
            // 
            lineDrawTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lineDrawTSSB.Font = new Font("Arial", 12F);
            lineDrawTSSB.Image = (Image)resources.GetObject("lineDrawTSSB.Image");
            lineDrawTSSB.ImageTransparentColor = Color.Magenta;
            lineDrawTSSB.Name = "lineDrawTSSB";
            lineDrawTSSB.Size = new Size(109, 22);
            lineDrawTSSB.Text = "Line";
            lineDrawTSSB.TextDirection = ToolStripTextDirection.Horizontal;
            lineDrawTSSB.ButtonClick += lineDrawTSSB_ButtonClick;
            // 
            // tianDrawTSSB
            // 
            tianDrawTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tianDrawTSSB.Font = new Font("Arial", 12F);
            tianDrawTSSB.Image = (Image)resources.GetObject("tianDrawTSSB.Image");
            tianDrawTSSB.ImageTransparentColor = Color.Magenta;
            tianDrawTSSB.Name = "tianDrawTSSB";
            tianDrawTSSB.Size = new Size(109, 22);
            tianDrawTSSB.Text = "Triangle";
            tianDrawTSSB.TextDirection = ToolStripTextDirection.Horizontal;
            tianDrawTSSB.ButtonClick += tianDrawTSSB_ButtonClick;
            // 
            // ellipseDrawTSSB
            // 
            ellipseDrawTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ellipseDrawTSSB.Font = new Font("Arial", 12F);
            ellipseDrawTSSB.Image = (Image)resources.GetObject("ellipseDrawTSSB.Image");
            ellipseDrawTSSB.ImageTransparentColor = Color.Magenta;
            ellipseDrawTSSB.Name = "ellipseDrawTSSB";
            ellipseDrawTSSB.Size = new Size(109, 22);
            ellipseDrawTSSB.Text = "Ellipse";
            ellipseDrawTSSB.TextDirection = ToolStripTextDirection.Horizontal;
            ellipseDrawTSSB.ButtonClick += ellipseDrawTSSB_ButtonClick;
            // 
            // circleDrawTSSB
            // 
            circleDrawTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            circleDrawTSSB.Font = new Font("Arial", 12F);
            circleDrawTSSB.Image = (Image)resources.GetObject("circleDrawTSSB.Image");
            circleDrawTSSB.ImageTransparentColor = Color.Magenta;
            circleDrawTSSB.Name = "circleDrawTSSB";
            circleDrawTSSB.Size = new Size(109, 22);
            circleDrawTSSB.Text = "Circle";
            circleDrawTSSB.TextDirection = ToolStripTextDirection.Horizontal;
            circleDrawTSSB.ButtonClick += circleDrawTSSB_ButtonClick;
            // 
            // brushDrawTSSB
            // 
            brushDrawTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            brushDrawTSSB.Font = new Font("Arial", 12F);
            brushDrawTSSB.Image = (Image)resources.GetObject("brushDrawTSSB.Image");
            brushDrawTSSB.ImageTransparentColor = Color.Magenta;
            brushDrawTSSB.Name = "brushDrawTSSB";
            brushDrawTSSB.Size = new Size(109, 22);
            brushDrawTSSB.Text = "Brush";
            brushDrawTSSB.TextDirection = ToolStripTextDirection.Horizontal;
            brushDrawTSSB.ButtonClick += brushDrawTSSB_ButtonClick;
            // 
            // erraseToolTSSB
            // 
            erraseToolTSSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            erraseToolTSSB.Font = new Font("Arial", 12F);
            erraseToolTSSB.Image = (Image)resources.GetObject("erraseToolTSSB.Image");
            erraseToolTSSB.ImageTransparentColor = Color.Magenta;
            erraseToolTSSB.Name = "erraseToolTSSB";
            erraseToolTSSB.Size = new Size(109, 22);
            erraseToolTSSB.Text = "Errase";
            erraseToolTSSB.TextDirection = ToolStripTextDirection.Horizontal;
            erraseToolTSSB.ButtonClick += erraseToolTSSB_ButtonClick;
            // 
            // mainPicture
            // 
            mainPicture.BackColor = Color.White;
            mainPicture.Cursor = Cursors.Cross;
            mainPicture.Location = new Point(124, 74);
            mainPicture.Name = "mainPicture";
            mainPicture.Size = new Size(836, 433);
            mainPicture.TabIndex = 2;
            mainPicture.TabStop = false;
            mainPicture.Paint += mainPicture_Paint;
            mainPicture.MouseDown += mainPicture_MouseDown;
            mainPicture.MouseMove += mainPicture_MouseMove;
            mainPicture.MouseUp += mainPicture_MouseUp;
            // 
            // propToolStrip
            // 
            propToolStrip.AutoSize = false;
            propToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            propToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, ColorInfoAndChangeToolStripButton, toolStripSeparator1, toolStripSeparator2, toolStripLabel2, SizeToolStripComboBox, toolStripSeparator3, toolStripLabel3, toolStripLabel4, toolStripLabel5 });
            propToolStrip.Location = new Point(111, 24);
            propToolStrip.Name = "propToolStrip";
            propToolStrip.Size = new Size(861, 25);
            propToolStrip.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(51, 22);
            toolStripLabel1.Text = "   Color: ";
            // 
            // ColorInfoAndChangeToolStripButton
            // 
            ColorInfoAndChangeToolStripButton.AutoSize = false;
            ColorInfoAndChangeToolStripButton.BackColor = Color.Black;
            ColorInfoAndChangeToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ColorInfoAndChangeToolStripButton.Image = (Image)resources.GetObject("ColorInfoAndChangeToolStripButton.Image");
            ColorInfoAndChangeToolStripButton.ImageTransparentColor = Color.Magenta;
            ColorInfoAndChangeToolStripButton.Name = "ColorInfoAndChangeToolStripButton";
            ColorInfoAndChangeToolStripButton.Size = new Size(23, 22);
            ColorInfoAndChangeToolStripButton.Text = " ";
            ColorInfoAndChangeToolStripButton.ToolTipText = "Click to change color";
            ColorInfoAndChangeToolStripButton.Click += ColorInfoAndChangeToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(33, 22);
            toolStripLabel2.Text = "Size: ";
            // 
            // SizeToolStripComboBox
            // 
            SizeToolStripComboBox.Name = "SizeToolStripComboBox";
            SizeToolStripComboBox.Size = new Size(121, 25);
            SizeToolStripComboBox.ToolTipText = "Change draw size";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(48, 22);
            toolStripLabel3.Text = "Undo";
            toolStripLabel3.Click += toolStripLabel3_Click;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Font = new Font("Nova Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(39, 22);
            toolStripLabel4.Text = "<=>";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(46, 22);
            toolStripLabel5.Text = "Redo";
            toolStripLabel5.Click += toolStripLabel5_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.AutoSize = false;
            StatusStrip.BackColor = Color.FromArgb(255, 255, 192);
            StatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, StatusModeStripValue, toolStripStatusLabel2, DrawingStatusShow });
            StatusStrip.Location = new Point(111, 528);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(861, 35);
            StatusStrip.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(120, 30);
            toolStripStatusLabel1.Text = "Current mode: ";
            // 
            // StatusModeStripValue
            // 
            StatusModeStripValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            StatusModeStripValue.Name = "StatusModeStripValue";
            StatusModeStripValue.Size = new Size(50, 30);
            StatusModeStripValue.Text = "None";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(635, 30);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.Text = " ";
            // 
            // DrawingStatusShow
            // 
            DrawingStatusShow.Name = "DrawingStatusShow";
            DrawingStatusShow.Size = new Size(10, 30);
            DrawingStatusShow.Text = " ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(71, 151, 73);
            ClientSize = new Size(972, 563);
            Controls.Add(StatusStrip);
            Controls.Add(propToolStrip);
            Controls.Add(mainPicture);
            Controls.Add(toolsToolStrip);
            Controls.Add(menuBarStrip);
            MainMenuStrip = menuBarStrip;
            Name = "MainForm";
            Text = "WinForm";
            SizeChanged += MainForm_SizeChanged;
            menuBarStrip.ResumeLayout(false);
            menuBarStrip.PerformLayout();
            toolsToolStrip.ResumeLayout(false);
            toolsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPicture).EndInit();
            propToolStrip.ResumeLayout(false);
            propToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuBarStrip;
        private ToolStrip toolsToolStrip;
        private ToolStripSplitButton rectDrawTSSB;
        private ToolStripSplitButton lineDrawTSSB;
        private ToolStripSplitButton tianDrawTSSB;
        private ToolStripSplitButton ellipseDrawTSSB;
        private ToolStripSplitButton circleDrawTSSB;
        private ToolStripSplitButton brushDrawTSSB;
        private ToolStripSplitButton erraseToolTSSB;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem openFileTSMI;
        private ToolStripMenuItem saveAsTSMI;
        private PictureBox mainPicture;
        private ToolStrip propToolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton ColorInfoAndChangeToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox SizeToolStripComboBox;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripLabel toolStripLabel5;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel StatusModeStripValue;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel DrawingStatusShow;
    }
}
