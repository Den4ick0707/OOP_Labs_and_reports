namespace Lab_WinForm_Daryev
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            MainMenuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            openFileTSMI = new ToolStripMenuItem();
            saveFileTSMI = new ToolStripMenuItem();
            resetButtonTSMI = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            createTPC = new TabPage();
            withParChB = new CheckBox();
            createButton = new Button();
            phYearMTB = new MaskedTextBox();
            phNameTB = new TextBox();
            phModelTB = new TextBox();
            phPriceTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            filterTPC = new TabPage();
            priceFilterCB = new CheckBox();
            yearFilterCB = new CheckBox();
            modelFilterCB = new CheckBox();
            nameFilterCB = new CheckBox();
            filterButton = new Button();
            yearFilterTB = new MaskedTextBox();
            nameFilterTB = new TextBox();
            modelFilterTB = new TextBox();
            priceFilterTB = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            searchTPC = new TabPage();
            yearSearchValTB = new MaskedTextBox();
            searchByPriceRB = new RadioButton();
            searchByYearRB = new RadioButton();
            searchByModelRB = new RadioButton();
            searchNameRB = new RadioButton();
            label9 = new Label();
            allSearchValueTB = new TextBox();
            searchButton = new Button();
            dataGridView1 = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            classCountL = new ToolStripStatusLabel();
            MainMenuStrip.SuspendLayout();
            tabControl1.SuspendLayout();
            createTPC.SuspendLayout();
            filterTPC.SuspendLayout();
            searchTPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.BackColor = Color.FromArgb(247, 241, 234);
            MainMenuStrip.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip.GripStyle = ToolStripGripStyle.Visible;
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, resetButtonTSMI });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(1284, 32);
            MainMenuStrip.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openFileTSMI, saveFileTSMI });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(56, 28);
            toolStripMenuItem1.Text = "File";
            // 
            // openFileTSMI
            // 
            openFileTSMI.Name = "openFileTSMI";
            openFileTSMI.Size = new Size(130, 28);
            openFileTSMI.Text = "Open";
            openFileTSMI.Click += openFileTSMI_Click;
            // 
            // saveFileTSMI
            // 
            saveFileTSMI.Name = "saveFileTSMI";
            saveFileTSMI.Size = new Size(130, 28);
            saveFileTSMI.Text = "Save";
            saveFileTSMI.Click += saveFileTSMI_Click;
            // 
            // resetButtonTSMI
            // 
            resetButtonTSMI.Name = "resetButtonTSMI";
            resetButtonTSMI.Size = new Size(78, 28);
            resetButtonTSMI.Text = "Reset";
            resetButtonTSMI.Click += resetButtonTSMI_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tabControl1.Controls.Add(createTPC);
            tabControl1.Controls.Add(filterTPC);
            tabControl1.Controls.Add(searchTPC);
            tabControl1.Location = new Point(12, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(465, 529);
            tabControl1.TabIndex = 1;
            // 
            // createTPC
            // 
            createTPC.BackColor = Color.FromArgb(255, 230, 188);
            createTPC.Controls.Add(withParChB);
            createTPC.Controls.Add(createButton);
            createTPC.Controls.Add(phYearMTB);
            createTPC.Controls.Add(phNameTB);
            createTPC.Controls.Add(phModelTB);
            createTPC.Controls.Add(phPriceTB);
            createTPC.Controls.Add(label4);
            createTPC.Controls.Add(label3);
            createTPC.Controls.Add(label2);
            createTPC.Controls.Add(label1);
            createTPC.Font = new Font("Arial", 12F);
            createTPC.Location = new Point(4, 24);
            createTPC.Name = "createTPC";
            createTPC.Padding = new Padding(3);
            createTPC.Size = new Size(457, 501);
            createTPC.TabIndex = 0;
            createTPC.Text = "Create";
            // 
            // withParChB
            // 
            withParChB.Appearance = Appearance.Button;
            withParChB.Location = new Point(309, 448);
            withParChB.Name = "withParChB";
            withParChB.Size = new Size(145, 46);
            withParChB.TabIndex = 9;
            withParChB.Text = "Without parameters";
            withParChB.TextAlign = ContentAlignment.MiddleCenter;
            withParChB.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createButton.Location = new Point(6, 447);
            createButton.Name = "createButton";
            createButton.Size = new Size(294, 46);
            createButton.TabIndex = 8;
            createButton.Text = "CREATE";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // phYearMTB
            // 
            phYearMTB.Font = new Font("Arial", 15.75F);
            phYearMTB.Location = new Point(19, 234);
            phYearMTB.Mask = "00/00/0000";
            phYearMTB.Name = "phYearMTB";
            phYearMTB.Size = new Size(281, 32);
            phYearMTB.TabIndex = 7;
            phYearMTB.ValidatingType = typeof(DateTime);
            phYearMTB.KeyPress += ControlInput;
            // 
            // phNameTB
            // 
            phNameTB.Font = new Font("Arial", 15.75F);
            phNameTB.Location = new Point(19, 37);
            phNameTB.Name = "phNameTB";
            phNameTB.Size = new Size(281, 32);
            phNameTB.TabIndex = 6;
            phNameTB.KeyPress += ControlInput;
            // 
            // phModelTB
            // 
            phModelTB.Font = new Font("Arial", 15.75F);
            phModelTB.Location = new Point(19, 137);
            phModelTB.Name = "phModelTB";
            phModelTB.Size = new Size(281, 32);
            phModelTB.TabIndex = 5;
            phModelTB.KeyPress += ControlInput;
            // 
            // phPriceTB
            // 
            phPriceTB.Font = new Font("Arial", 15.75F);
            phPriceTB.Location = new Point(19, 334);
            phPriceTB.Name = "phPriceTB";
            phPriceTB.Size = new Size(281, 32);
            phPriceTB.TabIndex = 4;
            phPriceTB.KeyPress += ControlInput;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(19, 369);
            label4.Name = "label4";
            label4.Size = new Size(45, 18);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(19, 269);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(19, 172);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(19, 72);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.UseMnemonic = false;
            // 
            // filterTPC
            // 
            filterTPC.BackColor = Color.FromArgb(255, 230, 188);
            filterTPC.Controls.Add(priceFilterCB);
            filterTPC.Controls.Add(yearFilterCB);
            filterTPC.Controls.Add(modelFilterCB);
            filterTPC.Controls.Add(nameFilterCB);
            filterTPC.Controls.Add(filterButton);
            filterTPC.Controls.Add(yearFilterTB);
            filterTPC.Controls.Add(nameFilterTB);
            filterTPC.Controls.Add(modelFilterTB);
            filterTPC.Controls.Add(priceFilterTB);
            filterTPC.Controls.Add(label5);
            filterTPC.Controls.Add(label6);
            filterTPC.Controls.Add(label7);
            filterTPC.Controls.Add(label8);
            filterTPC.Font = new Font("Arial", 12F);
            filterTPC.Location = new Point(4, 24);
            filterTPC.Name = "filterTPC";
            filterTPC.Padding = new Padding(3);
            filterTPC.Size = new Size(457, 501);
            filterTPC.TabIndex = 1;
            filterTPC.Text = "Filter";
            // 
            // priceFilterCB
            // 
            priceFilterCB.Appearance = Appearance.Button;
            priceFilterCB.Location = new Point(302, 205);
            priceFilterCB.Name = "priceFilterCB";
            priceFilterCB.Size = new Size(38, 32);
            priceFilterCB.TabIndex = 20;
            priceFilterCB.UseVisualStyleBackColor = true;
            // 
            // yearFilterCB
            // 
            yearFilterCB.Appearance = Appearance.Button;
            yearFilterCB.Location = new Point(302, 140);
            yearFilterCB.Name = "yearFilterCB";
            yearFilterCB.Size = new Size(38, 32);
            yearFilterCB.TabIndex = 19;
            yearFilterCB.UseVisualStyleBackColor = true;
            // 
            // modelFilterCB
            // 
            modelFilterCB.Appearance = Appearance.Button;
            modelFilterCB.Location = new Point(302, 72);
            modelFilterCB.Name = "modelFilterCB";
            modelFilterCB.Size = new Size(38, 32);
            modelFilterCB.TabIndex = 18;
            modelFilterCB.UseVisualStyleBackColor = true;
            // 
            // nameFilterCB
            // 
            nameFilterCB.Appearance = Appearance.Button;
            nameFilterCB.Location = new Point(302, 6);
            nameFilterCB.Name = "nameFilterCB";
            nameFilterCB.Size = new Size(38, 32);
            nameFilterCB.TabIndex = 17;
            nameFilterCB.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            filterButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterButton.Location = new Point(6, 435);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(278, 49);
            filterButton.TabIndex = 16;
            filterButton.Text = "Start Filtering";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // yearFilterTB
            // 
            yearFilterTB.Font = new Font("Arial", 15.75F);
            yearFilterTB.Location = new Point(3, 140);
            yearFilterTB.Mask = "00/00/0000";
            yearFilterTB.Name = "yearFilterTB";
            yearFilterTB.Size = new Size(281, 32);
            yearFilterTB.TabIndex = 15;
            yearFilterTB.ValidatingType = typeof(DateTime);
            yearFilterTB.KeyPress += ControlInput;
            // 
            // nameFilterTB
            // 
            nameFilterTB.Font = new Font("Arial", 15.75F);
            nameFilterTB.Location = new Point(6, 6);
            nameFilterTB.Name = "nameFilterTB";
            nameFilterTB.Size = new Size(281, 32);
            nameFilterTB.TabIndex = 14;
            nameFilterTB.KeyPress += ControlInput;
            // 
            // modelFilterTB
            // 
            modelFilterTB.Font = new Font("Arial", 15.75F);
            modelFilterTB.Location = new Point(3, 72);
            modelFilterTB.Name = "modelFilterTB";
            modelFilterTB.Size = new Size(281, 32);
            modelFilterTB.TabIndex = 13;
            modelFilterTB.KeyPress += ControlInput;
            // 
            // priceFilterTB
            // 
            priceFilterTB.Font = new Font("Arial", 15.75F);
            priceFilterTB.Location = new Point(3, 205);
            priceFilterTB.Name = "priceFilterTB";
            priceFilterTB.Size = new Size(281, 32);
            priceFilterTB.TabIndex = 12;
            priceFilterTB.KeyPress += ControlInput;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(3, 240);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 11;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(3, 175);
            label6.Name = "label6";
            label6.Size = new Size(39, 18);
            label6.TabIndex = 10;
            label6.Text = "Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(3, 107);
            label7.Name = "label7";
            label7.Size = new Size(51, 18);
            label7.TabIndex = 9;
            label7.Text = "Model";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(6, 41);
            label8.Name = "label8";
            label8.Size = new Size(50, 18);
            label8.TabIndex = 8;
            label8.Text = "Name";
            label8.UseMnemonic = false;
            // 
            // searchTPC
            // 
            searchTPC.BackColor = Color.FromArgb(255, 230, 188);
            searchTPC.Controls.Add(yearSearchValTB);
            searchTPC.Controls.Add(searchByPriceRB);
            searchTPC.Controls.Add(searchByYearRB);
            searchTPC.Controls.Add(searchByModelRB);
            searchTPC.Controls.Add(searchNameRB);
            searchTPC.Controls.Add(label9);
            searchTPC.Controls.Add(allSearchValueTB);
            searchTPC.Controls.Add(searchButton);
            searchTPC.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTPC.Location = new Point(4, 24);
            searchTPC.Name = "searchTPC";
            searchTPC.Size = new Size(457, 501);
            searchTPC.TabIndex = 2;
            searchTPC.Text = "Search";
            // 
            // yearSearchValTB
            // 
            yearSearchValTB.Font = new Font("Arial", 15.75F);
            yearSearchValTB.Location = new Point(14, 25);
            yearSearchValTB.Mask = "00/00/0000";
            yearSearchValTB.Name = "yearSearchValTB";
            yearSearchValTB.Size = new Size(307, 32);
            yearSearchValTB.TabIndex = 16;
            yearSearchValTB.ValidatingType = typeof(DateTime);
            yearSearchValTB.Visible = false;
            yearSearchValTB.KeyPress += searchTBControlInput;
            // 
            // searchByPriceRB
            // 
            searchByPriceRB.AutoSize = true;
            searchByPriceRB.Location = new Point(17, 240);
            searchByPriceRB.Name = "searchByPriceRB";
            searchByPriceRB.Size = new Size(135, 22);
            searchByPriceRB.TabIndex = 6;
            searchByPriceRB.TabStop = true;
            searchByPriceRB.Text = "Search by price";
            searchByPriceRB.UseVisualStyleBackColor = true;
            // 
            // searchByYearRB
            // 
            searchByYearRB.AutoSize = true;
            searchByYearRB.Location = new Point(17, 198);
            searchByYearRB.Name = "searchByYearRB";
            searchByYearRB.Size = new Size(130, 22);
            searchByYearRB.TabIndex = 5;
            searchByYearRB.TabStop = true;
            searchByYearRB.Text = "Search by year";
            searchByYearRB.UseVisualStyleBackColor = true;
            searchByYearRB.CheckedChanged += searchByYearRB_CheckedChanged;
            // 
            // searchByModelRB
            // 
            searchByModelRB.AutoSize = true;
            searchByModelRB.Location = new Point(17, 155);
            searchByModelRB.Name = "searchByModelRB";
            searchByModelRB.Size = new Size(143, 22);
            searchByModelRB.TabIndex = 4;
            searchByModelRB.TabStop = true;
            searchByModelRB.Text = "Search by model";
            searchByModelRB.UseVisualStyleBackColor = true;
            // 
            // searchNameRB
            // 
            searchNameRB.AutoSize = true;
            searchNameRB.Location = new Point(17, 116);
            searchNameRB.Name = "searchNameRB";
            searchNameRB.Size = new Size(139, 22);
            searchNameRB.TabIndex = 3;
            searchNameRB.TabStop = true;
            searchNameRB.Text = "Search by name";
            searchNameRB.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 60);
            label9.Name = "label9";
            label9.Size = new Size(98, 18);
            label9.TabIndex = 2;
            label9.Text = "Search value";
            // 
            // allSearchValueTB
            // 
            allSearchValueTB.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allSearchValueTB.Location = new Point(14, 25);
            allSearchValueTB.Name = "allSearchValueTB";
            allSearchValueTB.Size = new Size(307, 32);
            allSearchValueTB.TabIndex = 1;
            allSearchValueTB.KeyPress += searchTBControlInput;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(14, 427);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(427, 58);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(247, 241, 234);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(535, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.SelectionBackColor = Color.Moccasin;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(737, 501);
            dataGridView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(247, 241, 234);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, classCountL });
            statusStrip1.Location = new Point(0, 592);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1284, 23);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(111, 18);
            toolStripStatusLabel1.Text = "Class counter: ";
            // 
            // classCountL
            // 
            classCountL.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classCountL.Name = "classCountL";
            classCountL.Size = new Size(17, 18);
            classCountL.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(48, 42, 24);
            ClientSize = new Size(1284, 615);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(tabControl1);
            Controls.Add(MainMenuStrip);
            Name = "MainForm";
            Text = "WinForm_Daryev";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            tabControl1.ResumeLayout(false);
            createTPC.ResumeLayout(false);
            createTPC.PerformLayout();
            filterTPC.ResumeLayout(false);
            filterTPC.PerformLayout();
            searchTPC.ResumeLayout(false);
            searchTPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openFileTSMI;
        private ToolStripMenuItem saveFileTSMI;
        private TabControl tabControl1;
        private TabPage createTPC;
        private TabPage filterTPC;
        private DataGridView dataGridView1;
        private TabPage searchTPC;
        private Button createButton;
        private MaskedTextBox phYearMTB;
        private TextBox phNameTB;
        private TextBox phModelTB;
        private TextBox phPriceTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox withParChB;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel classCountL;
        private MaskedTextBox yearFilterTB;
        private TextBox nameFilterTB;
        private TextBox modelFilterTB;
        private TextBox priceFilterTB;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ToolStripMenuItem resetButtonTSMI;
        private CheckBox nameFilterCB;
        private Button filterButton;
        private CheckBox priceFilterCB;
        private CheckBox yearFilterCB;
        private CheckBox modelFilterCB;
        private Button searchButton;
        private Label label9;
        private TextBox allSearchValueTB;
        private RadioButton searchByPriceRB;
        private RadioButton searchByYearRB;
        private RadioButton searchByModelRB;
        private RadioButton searchNameRB;
        private MaskedTextBox yearSearchValTB;
    }
}
