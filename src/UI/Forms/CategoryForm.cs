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
        }

        private void LoadCategories()
        {
            dgvCategories.DataSource = _categoryBLL.GetAllCategories();
        }

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
            if (_selectedCategory != null)
            {
                _selectedCategory.Name = txtName.Text;
                _selectedCategory.Description = txtDescription.Text;

                _categoryBLL.UpdateCategory(_selectedCategory);
                LoadCategories();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategory != null)
            {
                _categoryBLL.DeleteCategory(_selectedCategory.Id);
                _selectedCategory = null;
                ClearCategoryFields();
                LoadCategories();
            }
        }

        private void ClearCategoryFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
