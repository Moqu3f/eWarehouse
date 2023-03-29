using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using Models;

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

            cmbCategory.DataSource = _providerBLL.GetAllProviders();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";


            cmbProvider.DataSource = _categoryBLL.GetAllCategories();
            cmbProvider.DisplayMember = "Name";
            cmbProvider.ValueMember = "Id";
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProduct();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //var product = new Product()
            //{
            //    Name = txtName.Text,
            //    Description = txtDescriprtion.Text,
            //    Availability = checkBox1.Checked,
            //    Category = _categoryBLL.GetCategoryById((long)cmbCategory.SelectedItem),
            //    Provider = _providerBLL.GetProviderById((long)cmbProvider.SelectedItem),
            //};

            //_productBLL.CreateProduct(product);

         
            LoadProduct();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
