using System.Data;
using System.IO;
using System.Numerics;

namespace Lab_WinForm_Daryev
{
    public partial class MainForm : Form
    {
        private List<PhoneClass> phoneList;
        private DataTable DT;
        private DataTable filteredDT; // Filter results
        private DataTable searchDT; // Search results
        private int classCounter;
        // -------------------------- Constructor ---------------------------
        public MainForm()
        {
            InitializeComponent();
            phoneList = new List<PhoneClass>();
            DT = new DataTable();

            DT.Columns.Add("Company", typeof(string));
            DT.Columns.Add("Phone model", typeof(string));
            DT.Columns.Add("Phone year", typeof(DateTime));
            DT.Columns.Add("Price", typeof(int));

            filteredDT = DT.Clone();
            searchDT = DT.Clone();

            dataGridView1.DataSource = DT;
        }

        // ------------------------ Input controls -------------------------
        private void ControlInput(object sender, KeyPressEventArgs e)
        {
            switch (sender)
            {
                case TextBox tb:
                    switch (tb.Name)
                    {
                        case "modelFilterTB":
                        case "nameFilterTB":
                        case "phNameTB":
                        case "phModelTB":
                            if (e.KeyChar != '-' && !char.IsDigit(e.KeyChar) &&
                                !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                                e.Handled = true;
                            break;

                        case "phYearMTB":
                        case "yearFilterTB":
                            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                                e.Handled = true;
                            break;

                        case "phPriceTB":
                        case "priceFilterTB":
                            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                                e.Handled = true;

                            if (e.KeyChar == '.')
                            {

                                if (tb.Text.Contains('.') || tb.SelectionStart == 0)
                                    e.Handled = true;
                            }
                            break;
                    }
                    break;

                case MaskedTextBox mtb:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
            }
        }
        private void searchTBControlInput(object sender, KeyPressEventArgs e)
        {
            if (searchByYearRB.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar != '-' && !char.IsDigit(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }
        // --------------------- Update class counter -----------------------
        private void UpdateCounter()
        {
            classCountL.Text = phoneList.Count.ToString();
        }
        // ---------------------------- Events ------------------------------
        // Create object
        private void createButton_Click(object sender, EventArgs e)
        {
            if (withParChB.CheckState == CheckState.Checked)
            {
                var phOne = new PhoneClass();
                phoneList.Add(phOne);
                DT.Rows.Add(phOne.phoneName, phOne.phoneModel, phOne.phoneYear, phOne.phonePrice);
                UpdateCounter();
                return;
            }
            if (!ValidateInputs(out string company, out string model, out DateTime year, out double price))
                return;

            var phone = new PhoneClass(company, model, year, price);
            phoneList.Add(phone);
            DT.Rows.Add(phone.phoneName, phone.phoneModel, phone.phoneYear, phone.phonePrice);
            phNameTB.Clear();
            phModelTB.Clear();
            phYearMTB.Clear();
            phPriceTB.Clear();
            UpdateCounter();
        }
        // Save file
        private void saveFileTSMI_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            string filePath;
            saveFile.Filter = "Binary File(.bin)|*.bin";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFile.FileName;
                using (var binWritter = new BinaryWriter(new FileStream(filePath, FileMode.Create)))
                {
                    foreach (var value in phoneList)
                    {
                        binWritter.Write(value.phoneName);
                        binWritter.Write(value.phoneModel);
                        binWritter.Write(value.phoneYear.Date.ToBinary());
                        binWritter.Write(value.phonePrice);
                    }
                }
            }
        }
        // Open file
        private void openFileTSMI_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            string filePath;
            openFile.Filter = "Binary File(.bin)|*.bin";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;

                phoneList.Clear();
                try
                {
                    using (var binReader = new BinaryReader(new FileStream(filePath, FileMode.Open)))
                    {
                        while (binReader.BaseStream.Position < binReader.BaseStream.Length)
                        {
                            var value = new PhoneClass
                            {
                                phoneName = binReader.ReadString(),
                                phoneModel = binReader.ReadString(),
                                phoneYear = DateTime.FromBinary(binReader.ReadInt64()),
                                phonePrice = binReader.ReadDouble()
                            };
                            phoneList.Add(value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (var phone in phoneList)
                {
                    DT.Rows.Add(phone.phoneName, phone.phoneModel, phone.phoneYear, phone.phonePrice);
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            var filteredList = new List<PhoneClass>();

            foreach (var phone in phoneList)
            {
                bool matches = true;

                if (nameFilterCB.Checked && !string.IsNullOrWhiteSpace(nameFilterTB.Text))
                {
                    if (!phone.phoneName.Equals(nameFilterTB.Text, StringComparison.OrdinalIgnoreCase))
                        matches = false;
                }

                if (modelFilterCB.Checked && !string.IsNullOrWhiteSpace(modelFilterTB.Text))
                {
                    if (!phone.phoneModel.Equals(modelFilterTB.Text, StringComparison.OrdinalIgnoreCase))
                        matches = false;
                }

                if (yearFilterCB.Checked && DateTime.TryParse(yearFilterTB.Text, out DateTime year))
                {
                    if (phone.phoneYear != year)
                        matches = false;
                }

                if (priceFilterCB.Checked && double.TryParse(priceFilterTB.Text, out double price))
                {
                    if (phone.phonePrice != price)
                        matches = false;
                }

                if (matches)
                    filteredList.Add(phone);
            }

            filteredDT.Clear();
            foreach (var phone in filteredList)
            {
                filteredDT.Rows.Add(phone.phoneName, phone.phoneModel, phone.phoneYear, phone.phonePrice);
            }

            dataGridView1.DataSource = filteredDT;
        }
        private void resetButtonTSMI_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DT;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchList = new List<PhoneClass>();

            DateTime year;
            double price;

            foreach (var phone in phoneList)
            {
                bool matches = true;


                if (searchNameRB.Checked)
                {
                    if (!phone.phoneName.Equals(allSearchValueTB.Text, StringComparison.OrdinalIgnoreCase))
                        matches = false;
                }


                if (searchByModelRB.Checked)
                {
                    if (!phone.phoneModel.Equals(allSearchValueTB.Text, StringComparison.OrdinalIgnoreCase))
                        matches = false;
                }


                if (searchByYearRB.Checked)
                {
                    if (DateTime.TryParse(yearSearchValTB.Text, out year))
                    {
                        if (phone.phoneYear != year)
                            matches = false;
                    }
                }

                if (searchByPriceRB.Checked)
                {
                    if (double.TryParse(allSearchValueTB.Text, out price))
                    {
                        if (phone.phonePrice != price)
                            matches = false;
                    }
                }

                if (matches)
                    searchList.Add(phone);
            }

            searchDT.Clear();
            foreach (var phone in searchList)
            {
                searchDT.Rows.Add(phone.phoneName, phone.phoneModel, phone.phoneYear, phone.phonePrice);
            }

            dataGridView1.DataSource = searchDT;
        }
        private void searchByYearRB_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByYearRB.Checked)
            {
                yearSearchValTB.Visible = true;
                allSearchValueTB.Visible = false;
            }
            else
            {
                yearSearchValTB.Visible = false;
                allSearchValueTB.Visible = true;
            }
        }



        // --------------------------- Methodes ---------------------------- 
        // Validate parametrs
        private bool ValidateInputs(out string company, out string model, out DateTime year, out double price)
        {
            company = phNameTB.Text.Trim();
            model = phModelTB.Text.Trim();
            year = DateTime.MinValue;
            price = 0;

            if (string.IsNullOrWhiteSpace(company) ||
                string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(phYearMTB.Text) ||
                string.IsNullOrWhiteSpace(phPriceTB.Text))
            {
                MessageBox.Show("Please, fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(phYearMTB.Text, out year))
            {
                MessageBox.Show("Year is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (year <= new DateTime(1960, 01, 01))
            {
                year = new DateTime(1960, 01, 01);
            }
            else if (year >= DateTime.Now)
            {
                year = DateTime.Now.Date;
            }

            if (!double.TryParse(phPriceTB.Text, out price) || price <= 0)
            {
                MessageBox.Show("Price must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



    }
}
