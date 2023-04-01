using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLogic.Interfaces;
using eWarehouse.BusinessLogic;
using Models;

namespace UI.Forms
{
    public partial class ProviderForm : Form
    {

        private IProviderBLL _providerBLL;
        private Provider _selectedProvider;

        public ProviderForm(IProviderBLL providerBLL)
        {
            InitializeComponent();
            _providerBLL = providerBLL;
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            LoadCategories();

            dgvProviders.Columns["Id"].HeaderText = "Id";
            dgvProviders.Columns["Name"].HeaderText = "Назва";
            dgvProviders.Columns["Surname"].HeaderText = "Прізвище";
            dgvProviders.Columns["Address"].HeaderText = "Адреса";
            dgvProviders.Columns["Email"].HeaderText = "Email";
            dgvProviders.Columns["Phone"].HeaderText = "Телефон";
            dgvProviders.Columns["Description"].HeaderText = "Опис";
            dgvProviders.Columns["Products"].Visible = false;
            dgvProviders.Columns["Id"].Width = 50;
            dgvProviders.Columns["Surname"].Width = 120;
            dgvProviders.Columns.Cast<DataGridViewColumn>().Skip(3).ToList().ForEach(c => c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill);
            dgvProviders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProviders.DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
            dgvProviders.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void LoadCategories()
        {
            dgvProviders.DataSource = _providerBLL.GetAllProviders();
        }

        private void dgvProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long id = (long)dgvProviders.Rows[e.RowIndex].Cells["id"].Value;
                _selectedProvider = _providerBLL.GetProviderById(id);
                UpdateCategoryFields();
            }
        }

        private void UpdateCategoryFields()
        {
            if (_selectedProvider != null)
            {
                txtName.Text = _selectedProvider.Name;
                txtSurname.Text = _selectedProvider.Surname;
                txtAddress.Text = _selectedProvider.Address;
                txtEmail.Text = _selectedProvider.Email;
                txtPhone.Text = _selectedProvider.Phone;
                txt_Description.Text = _selectedProvider.Description;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProvider != null)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що бажаєте видалити постачальника?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _providerBLL.DeleteProvider(_selectedProvider.Id);
                    _selectedProvider = null;
                    ClearProviderFields();
                    LoadCategories();
                }
            }
            else
            {
                MessageBox.Show("Постачальника не обрано.");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProvider != null)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtSurname.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть всі необхідні поля.");
                    return;
                }


                _selectedProvider.Name = txtName.Text;
                _selectedProvider.Surname = txtSurname.Text;
                _selectedProvider.Address = txtAddress.Text;
                _selectedProvider.Email = txtEmail.Text;
                _selectedProvider.Phone = txtPhone.Text;
                _selectedProvider.Description = txt_Description.Text;

                _providerBLL.UpdateProvider(_selectedProvider);
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Постачальника не обрано.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі необхідні поля.");
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Будь ласка, введіть коректну електронну адресу.");
                return;
            }

            if (!IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Будь ласка, введіть коректний номер телефону.");
                return;
            }

            var provider = new Provider
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text,
                Description = txt_Description.Text,
            };

            _providerBLL.CreateProvider(provider);
            LoadCategories();
        }

        private bool IsValidEmail(string email)
        {
            // This is a simple regular expression that checks if the email address
            // contains an "@" symbol and a valid domain name.
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // This regular expression checks if the phone number contains only digits
            // and is exactly 10 characters long.
            string pattern = @"^\+380\d{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }


        private void ClearProviderFields()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSurname.Text = "";
            txt_Description.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgvProviders != null)
            {
                int currentRowIndex = dgvProviders.CurrentCell?.RowIndex ?? -1;
                if (currentRowIndex < dgvProviders.Rows.Count - 1)
                {
                    dgvProviders.CurrentCell = dgvProviders.Rows[currentRowIndex + 1].Cells[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProviders != null)
            {
                int currentRowIndex = dgvProviders.CurrentCell?.RowIndex ?? -1;
                if (currentRowIndex > 0)
                {
                    dgvProviders.CurrentCell = dgvProviders.Rows[currentRowIndex - 1].Cells[0];
                }
            }
        }

        private void dgvProviders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProviders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProviders.SelectedRows[0];
                long id = (long)selectedRow.Cells["Id"].Value;
                _selectedProvider = _providerBLL.GetProviderById(id);
                UpdateCategoryFields();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvProviders.DataSource = _providerBLL.GetProvidersSortedByName();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvProviders.DataSource = _providerBLL.GetProvidersSortedBySurname();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearProviderFields();
        }
    }
}
