using System;
using System.Configuration;
using System.Diagnostics;

namespace NvidiaFpsLimitHelper
{
    public partial class AppSettings
    {
        //Check - Application Settings
        public static void Settings_Check()
        {
            try
            {
                if (ConfigurationManager.AppSettings["AppFirstLaunch"] == null) { Setting_Save("AppFirstLaunch", "True"); }
                if (ConfigurationManager.AppSettings["DisplayMonitor"] == null) { Setting_Save("DisplayMonitor", "1"); }
                if (ConfigurationManager.AppSettings["MaxFpsOffset"] == null) { Setting_Save("MaxFpsOffset", "0"); }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to check the application settings: " + ex.Message);
            }
        }
    }
}
