using System;
using System.Configuration;
using System.Diagnostics;

namespace NvidiaFpsLimitHelper
{
    public partial class MainWindow
    {
        //Check - Application Settings
        void Settings_Check()
        {
            try
            {
                if (ConfigurationManager.AppSettings["AppFirstLaunch"] == null) { SettingSave("AppFirstLaunch", "True"); }
                if (ConfigurationManager.AppSettings["DisplayMonitor"] == null) { SettingSave("DisplayMonitor", "1"); }
                if (ConfigurationManager.AppSettings["MaxFpsOffset"] == null) { SettingSave("MaxFpsOffset", "0"); }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to check the application settings: " + ex.Message);
            }
        }
    }
}
