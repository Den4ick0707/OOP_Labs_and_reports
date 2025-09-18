using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_1_Daryev
{
    public partial class Form1 : Form
    {
        int _Witdh = 800;
        int _Height = 500;
        public Form1()
        {
            InitializeComponent();
            Button[] buttons = new Button[6];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Size = new Size(300 - i * 20, 50);
                buttons[i].Location = new Point((_Witdh / 6) + (100 + i * 10), 60 + i * 60);
                if (i % 2 == 0)
                {
                    buttons[i].Font = new Font("Comic Sans MS", 16, FontStyle.Italic);
                    buttons[i].BackColor = Color.LightBlue;
                }
                else
                {
                    buttons[i].Font = new Font("Arial", 16, FontStyle.Italic);
                    buttons[i].BackColor = Color.Aquamarine;
                }
                buttons[i].Text = $"History {i + 1}";
                this.Controls.Add(buttons[i]);
                if (i == buttons.Length - 1)
                {
                    buttons[i].Click += new System.EventHandler(this.closeWindow);
                }
                else
                {
                    buttons[i].Click += new System.EventHandler(this.someButtonClick);
                }
            }

        }

        void closeWindow(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void someButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"You pressed {btn.Text}", "Button pressed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS IS NOT BUTTON", "THIS IS NOT BUTTON", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
