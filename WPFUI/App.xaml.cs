using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using BLL.Configuration;
using BLL.ServiceInterfaces;
using WPFUI.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //private ServiceProvider _serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            services.ConfigureBLL("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RailwayTicketingDB;Integrated Security=True");
            services.ConfigureEfServices();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<TicketViewModel>();

            ServiceProvider _serviceProvider = services.BuildServiceProvider();
            var ticketService = _serviceProvider.GetRequiredService<ITicketService>();
            //var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();

            //var mainWindow = new MainWindow();

            //mainWindow.DataContext = new TicketViewModel(ticketService);
            //mainWindow.Show();
        }
    }
}
