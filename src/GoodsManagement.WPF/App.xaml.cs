using System;
using System.Windows;

namespace GoodsManagement.WPF
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Initialize the main window and show it
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}