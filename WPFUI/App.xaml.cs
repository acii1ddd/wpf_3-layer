using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using BLL.Configuration;
using BLL.ServiceInterfaces;
using WPFUI.ViewModels;
using System.Configuration;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider _serviceProvider = services.BuildServiceProvider();
            var mainWindow = new MainWindow
            {
                DataContext = _serviceProvider.GetRequiredService<MainViewModel>()
            };
            mainWindow.Show();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            string efConnectionString = ConfigurationManager.ConnectionStrings["RailwayTicketingEF"].ConnectionString;
            services.ConfigureEfServices();
            services.ConfigureBLL(efConnectionString);

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<TicketViewModel>();
        }
    }
}
