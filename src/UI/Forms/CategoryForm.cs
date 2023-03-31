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
using BusinessLogic.BLL;
using BusinessLogic.Interfaces;
using Models;

namespace UI
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryBLL _categoryBLL;
        private Category _selectedCategory;

        public CategoryForm(ICategoryBLL categoryBLL)
        {
            InitializeComponent();
            _categoryBLL = categoryBLL;
        }


        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();

            dgvCategories.Columns["Id"].HeaderText = "Id";
            dgvCategories.Columns["Name"].HeaderText = "Назва";
            dgvCategories.Columns["Description"].HeaderText = "Опис";
            dgvCategories.Columns[3].Visible = false;

            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvCategories.DefaultCellStyle.SelectionForeColor = Color.Blue;

        }


        private void LoadCategories() => dgvCategories.DataSource = _categoryBLL.GetAllCategories();


        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long id = (long)dgvCategories.Rows[e.RowIndex].Cells["id"].Value;
                _selectedCategory = _categoryBLL.GetCategoryById(id);
                UpdateCategoryFields();
            }
        }


        private void UpdateCategoryFields()
        {
            if (_selectedCategory != null)
            {
                txtName.Text = _selectedCategory.Name;
                txtDescription.Text = _selectedCategory.Description;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Будь ласка, заповніть поля назви та опису категорії.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category category = new Category
            {
                Name = txtName.Text,
                Description = txtDescription.Text
            };

            _categoryBLL.CreateCategory(category);
            LoadCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null)
            {
                MessageBox.Show("Будь ласка, оберіть категорію для оновлення.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Будь ласка, заповніть поля назви та опису категорії.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectedCategory.Name = txtName.Text;
            _selectedCategory.Description = txtDescription.Text;

            _categoryBLL.UpdateCategory(_selectedCategory);
            LoadCategories();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null)
            {
                MessageBox.Show("Будь ласка, оберіть категорію для видалення.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _categoryBLL.DeleteCategory(_selectedCategory.Id);
            _selectedCategory = null;
            ClearCategoryFields();
            LoadCategories();
        }

        private void ClearCategoryFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvCategories.CurrentCell.RowIndex;
            if (currentRowIndex < dgvCategories.Rows.Count - 1)
            {
                dgvCategories.CurrentCell = dgvCategories.Rows[currentRowIndex + 1].Cells[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int currentRowIndex = dgvCategories.CurrentCell.RowIndex;
            if (currentRowIndex > 0)
            {
                dgvCategories.CurrentCell = dgvCategories.Rows[currentRowIndex - 1].Cells[0];
            }
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCategories.SelectedRows[0];
                long id = (long)selectedRow.Cells["Id"].Value;
                _selectedCategory = _categoryBLL.GetCategoryById(id);
                UpdateCategoryFields();
            }
        }
    }
}
