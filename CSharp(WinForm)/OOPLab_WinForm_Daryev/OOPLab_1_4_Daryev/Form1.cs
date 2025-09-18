using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace OOPLab_1_4_Daryev
{
    public partial class MainForm : Form
    {
        private readonly List<PhoneClass> phoneList;
        private readonly DataTable dt;

        public MainForm()
        {
            InitializeComponent();

            phoneList = new List<PhoneClass>();
            dt = new DataTable();

            dt.Columns.Add("Company", typeof(string));
            dt.Columns.Add("Phone model", typeof(string));
            dt.Columns.Add("Phone year", typeof(DateTime));
            dt.Columns.Add("Price", typeof(int));

            dataGridView1.DataSource = dt;
            UpdateCounter();
        }

        private void createWithoutParButton_Click(object sender, EventArgs e)
        {
            var phone = new PhoneClass();
            phoneList.Add(phone);
            dt.Rows.Add(phone.Company, phone.PhoneModel, phone.PhoneYear, phone.Price);
            UpdateCounter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string company, out string model, out DateTime year, out int price))
                return;

            var phone = new PhoneClass(company, model, price, year);
            phoneList.Add(phone);
            dt.Rows.Add(phone.Company, phone.PhoneModel, phone.PhoneYear, phone.Price);
            UpdateCounter();
        }

        private bool ValidateInputs(out string company, out string model, out DateTime year, out int price)
        {
            company = textBox1.Text.Trim();
            model = textBox2.Text.Trim();
            year = DateTime.MinValue;
            price = 0;

            if (string.IsNullOrWhiteSpace(company) ||
                string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please, fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(maskedTextBox1.Text, out year) || year < new DateTime(1950, 01, 01) || year > DateTime.Now)
            {
                MessageBox.Show("Year is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(textBox3.Text, out price) || price <= 0)
            {
                MessageBox.Show("Price must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void UpdateCounter()
        {
            classCountLabel.Text = phoneList.Count.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}
