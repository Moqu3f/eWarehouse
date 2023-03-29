using Microsoft.Extensions.DependencyInjection;
using UI.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnOpenCategories_Click_1(object sender, EventArgs e)
        {
            using (var categoryForm = _serviceProvider.GetService<CategoryForm>())
            {
                categoryForm.ShowDialog();
            }
        }

        private void btnOpenProviders_Click(object sender, EventArgs e)
        {
            using (var providerForm = _serviceProvider.GetService<ProviderForm>())
            {
                providerForm.ShowDialog();
            }
        }

        private void btnOpenProducts_Click(object sender, EventArgs e)
        {
            using (var productForm = _serviceProvider.GetService<ProductForm>())
            {
                productForm.ShowDialog();
            }
        }
    }
}