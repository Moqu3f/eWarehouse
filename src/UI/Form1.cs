using Microsoft.Extensions.DependencyInjection;

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

        private void btnOpenCategories_Click(object sender, EventArgs e)
        {
            using (var categoryForm = _serviceProvider.GetService<CategoryForm>())
            {
                categoryForm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}