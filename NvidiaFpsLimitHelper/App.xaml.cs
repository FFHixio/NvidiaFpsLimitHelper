using System.Windows;

namespace NvidiaFpsLimitHelper
{
    public partial class App : Application
    {
        //Application Windows
        public static MainWindow vMainWindow = new MainWindow();

        //Application Startup
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                AppStartup.Application_Startup();
            }
            catch { }
        }
    }
}