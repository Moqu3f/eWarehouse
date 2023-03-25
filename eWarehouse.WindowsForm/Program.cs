using Microsoft.Extensions.Hosting;
using WindowsFormsLifetime;

namespace eWarehouse.WindowsForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            CreateHostBuilder().Build().Run();


        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder(Array.Empty<string>())
                .UseWindowsFormsLifetime<Form1>()
                .ConfigureServices((hostContext, services) =>
                {
                    
                });
    }
}