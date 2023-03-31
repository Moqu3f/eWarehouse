using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Forms
{
    public partial class ProductForm : Form
    {

        private IProviderBLL _providerBLL;
        private IProductBLL _productBLL;
        private ICategoryBLL _categoryBLL;


        private Product _selectedProduct;
        private Category _selectedCategory;
        private Provider _selectedProvider;



        public ProductForm(IProviderBLL providerBll, IProductBLL productBll, ICategoryBLL categoryBll)
        {
            _productBLL = productBll;
            _providerBLL = providerBll;
            _categoryBLL = categoryBll;


            InitializeComponent();
        }


        private void LoadProduct()
        {
            dataGridView1.DataSource = _productBLL.GetAllProducts();


            dataGridView1.Columns["Id"].HeaderText = "Id";
            dataGridView1.Columns["Name"].HeaderText = "Назва";
            dataGridView1.Columns["Description"].HeaderText = "Опис";
            dataGridView1.Columns["Availability"].HeaderText = "Доступність";
            dataGridView1.Columns["Category"].HeaderText = "Категорія";
            dataGridView1.Columns["Customer"].HeaderText = "Покупець";


            dataGridView1.Columns["Brand"].HeaderText = "Бренд";
            dataGridView1.Columns["Price"].HeaderText = "Ціна";




            dataGridView1.Columns["CategoryId"].Visible = false;
            dataGridView1.Columns["ProviderId"].Visible = false;
            cmbProvider.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbProvider.DataSource = _providerBLL.GetAllProviders();
            cmbProvider.DisplayMember = "Name";
            cmbProvider.ValueMember = "Id";
            cmbCategory.DataSource = _categoryBLL.GetAllCategories();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProduct();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Blue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                long productId = (long)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                DeleteProduct(productId);
            }
            else
            {
                MessageBox.Show("Виберіть продукт для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProduct(long productId)
        {
            DialogResult result = MessageBox.Show("Видалити продукт?", "Видалення продукту", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _productBLL.DeleteProduct(productId);
                dataGridView1.DataSource = _productBLL.GetAllProducts();
                LoadProduct();
            }
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
            dataGridView1.DataSource = _productBLL.GetAllProducts();

        }

        private void UpdateProduct()
        {
            if (_selectedProduct == null)
            {
                return;
            }

            var name = txtName.Text.Trim();
            var customer = txtCustomer.Text.Trim();
            var description = txtDescriprtion.Text.Trim();
            var availability = checkBox1.Checked;
            var brand = txtBrand.Text.Trim();
            var price = txtPrice.Text.Trim();


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Назва і опис товару не можуть бути порожніми.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_selectedCategory == null || _selectedProvider == null)
            {
                MessageBox.Show("Будь ласка, виберіть категорію та постачальника для продукту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Бренд та ціна не можуть бути порожнім.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectedProduct.Name = name;
            _selectedProduct.Description = description;
            _selectedProduct.Customer = customer;
            _selectedProduct.Brand = brand;
            _selectedProduct.Price = decimal.TryParse(price, out decimal value) ? value : 0;
            _selectedProduct.Availability = availability;
            _selectedProduct.Provider = _selectedProvider;
            _selectedProduct.Category = _selectedCategory;

            _productBLL.UpdateProduct(_selectedProduct);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var description = txtDescriprtion.Text.Trim();
            var availability = checkBox1.Checked;
            var customer = txtCustomer.Text.Trim();
            var brand = txtBrand.Text.Trim();
            var price = txtPrice.Text.Trim();


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Назва і опис товару не можуть бути порожніми.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_selectedCategory == null || _selectedProvider == null)
            {
                MessageBox.Show("Будь ласка, виберіть категорію та постачальника для продукту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(customer))
            {
                MessageBox.Show("Будь ласка, ведіть замовника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Бренд та ціна не можуть бути порожнім.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var product = new Product()
            {
                Name = name,
                Customer = customer,
                Description = description,
                Brand = brand,
                Price = decimal.TryParse(price, out decimal value) ? value : 0,
                Availability = availability,
                Provider = _selectedProvider,
                Category = _selectedCategory
            };

            _productBLL.CreateProduct(product);


            LoadProduct();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCategory = (Category)cmbCategory.SelectedItem;
        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProvider = (Provider)cmbProvider.SelectedItem;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long id = (long)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                _selectedProduct = _productBLL.GetProductById(id);
                UpdateTextbox();
            }
        }

        private void UpdateTextbox()
        {
            txtName.Text = _selectedProduct.Name;
            txtDescriprtion.Text = _selectedProduct.Description;
            txtName.Text = _selectedProduct.Name;
            txtDescriprtion.Text = _selectedProduct.Description;
            txtCustomer.Text = _selectedProduct.Customer;

            txtBrand.Text = _selectedProduct.Brand;
            txtPrice.Text = _selectedProduct.Price + "";


            checkBox1.Checked = _selectedProduct.Availability;
            cmbCategory.SelectedItem = _selectedProduct.Category;
            cmbProvider.SelectedItem = _selectedProduct.Provider;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Category")
            {
                var product = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;
                if (product != null)
                {
                    e.Value = product.Category.Name;
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Provider")
            {
                var product = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;
                if (product != null)
                {
                    e.Value = product.Provider.Name;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescriprtion.Text = "";
            txtCustomer.Text = "";
            txtPrice.Text = "";
            txtBrand.Text = "";
            checkBox1.Checked = false;
            cmbCategory.SelectedIndex = -1;
            cmbProvider.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                int currentRowIndex = dataGridView1.CurrentCell?.RowIndex ?? -1;
                if (currentRowIndex < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentRowIndex + 1].Cells[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                int currentRowIndex = dataGridView1.CurrentCell?.RowIndex ?? -1;
                if (currentRowIndex > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentRowIndex - 1].Cells[0];
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                long id = (long)selectedRow.Cells["Id"].Value;
                _selectedProduct = _productBLL.GetProductById(id);
                UpdateTextbox();
            }
        }

        private void btnFindKeyword_Click(object sender, EventArgs e)
        => dataGridView1.DataSource = _productBLL.SearchProductsByKeyword(txtFindKeyword.Text);

        private void btnClient_Click(object sender, EventArgs e)
            => dataGridView1.DataSource = _productBLL.searchCustomerByProducts(txtFindClient.Text);

        private void bntSortBrand_Click(object sender, EventArgs e)
        => dataGridView1.DataSource = _productBLL.GetProductsSortedByBrand();

        private void bntSortPrice_Click(object sender, EventArgs e)
            => dataGridView1.DataSource = _productBLL.GetProductsSortedByPrice();

        private void bntSortName_Click(object sender, EventArgs e)
            => dataGridView1.DataSource = _productBLL.GetProductsSortedByName();


    }
}
