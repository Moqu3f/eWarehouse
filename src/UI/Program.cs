using BusinessLogic.BLL;
using BusinessLogic.Interfaces;
using DataAccess.DAO;
using DataAccess.Interfaces;
using eWarehouse.BusinessLogic;
using eWarehouse.DataAccess.DAO;
using eWarehouse.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Context;
using Microsoft.Extensions.Caching.Memory;
using UI.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = ConfigureServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetService<Form1>());
        }
        
        static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Add DbContext and connection string
            //var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eWarehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            //services.AddDbContext<eWarehouseDbContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<eWarehouseDbContext>(options => options.UseInMemoryDatabase(databaseName: "eWarehouseDB"));


            // Register DAOs and BLLs
            services.AddTransient<IProviderDAO, ProviderDAO>();
            services.AddTransient<IProductDAO, ProductDAO>();
            services.AddTransient<ICategoryDAO, CategoryDAO>();

            services.AddTransient<IProviderBLL, ProviderBLL>();
            services.AddTransient<IProductBLL, ProductBLL>();
            services.AddTransient<ICategoryBLL, CategoryBLL>();

            // Register forms
            services.AddTransient<Form1>();
            services.AddTransient<CategoryForm>();
            services.AddTransient<ProviderForm>();
            services.AddTransient<ProductForm>();

            return services.BuildServiceProvider();
        }
    }
}