using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            dgvProviders.Columns["Surname"].HeaderText = "Призвіще";
            dgvProviders.Columns["Address"].HeaderText = "Адреса";
            dgvProviders.Columns["Email"].HeaderText = "Email";
            dgvProviders.Columns["Phone"].HeaderText = "Телефон";
            dgvProviders.Columns["Description"].HeaderText = "Опис";
            dgvProviders.Columns["Products"].Visible = false;

            dgvProviders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProviders.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvProviders.DefaultCellStyle.SelectionForeColor = Color.Blue;
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
                txtSurname.Text = _selectedProvider.Name;
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
                _providerBLL.DeleteProvider(_selectedProvider.Id);
                _selectedProvider = null;
                ClearCategoryFields();
                LoadCategories();
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

        private void ClearCategoryFields()
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
            int currentRowIndex = dgvProviders.CurrentCell.RowIndex;
            if (currentRowIndex < dgvProviders.Rows.Count - 1)
            {
                dgvProviders.CurrentCell = dgvProviders.Rows[currentRowIndex + 1].Cells[0];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvProviders.CurrentCell.RowIndex;
            if (currentRowIndex > 0)
            {
                dgvProviders.CurrentCell = dgvProviders.Rows[currentRowIndex - 1].Cells[0];
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
    }
}
