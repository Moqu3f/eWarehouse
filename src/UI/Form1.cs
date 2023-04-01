using BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using UI.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ICategoryBLL _categoryBLL;

        public Form1(IServiceProvider serviceProvider, ICategoryBLL category)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _categoryBLL = category;
        }

        private void btnOpenCategories_Click(object sender, EventArgs e)
        {
            using (var categoryForm = _serviceProvider.GetService<CategoryForm>())
            {
                categoryForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var providerForm = _serviceProvider.GetService<ProviderForm>())
            {
                providerForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var productForm = _serviceProvider.GetService<ProductForm>())
            {
                productForm.ShowDialog();
            }
        }
    }
}