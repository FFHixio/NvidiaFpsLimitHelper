using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace NvidiaFpsLimitHelper
{
    public partial class MainWindow
    {
        //Load - Application Settings
        bool Settings_Load()
        {
            try
            {
                //Load - Display monitor
                int monitorNumber = Convert.ToInt32(ConfigurationManager.AppSettings["DisplayMonitor"]);
                textblock_SettingsDisplayMonitor.Text = textblock_SettingsDisplayMonitor.Tag.ToString() + monitorNumber;
                slider_SettingsDisplayMonitor.Value = monitorNumber;
                slider_SettingsDisplayMonitor.Maximum = Screen.AllScreens.Count();

                //Load - Maximum fps offset
                int maxFpsOffset = Convert.ToInt32(ConfigurationManager.AppSettings["MaxFpsOffset"]);
                textblock_SettingsMaxFpsOffset.Text = textblock_SettingsMaxFpsOffset.Tag.ToString() + maxFpsOffset;
                slider_SettingsMaxFpsOffset.Value = maxFpsOffset;

                //Check if application is set to launch on Windows startup
                string targetAssemblyName = Assembly.GetEntryAssembly().GetName().Name;
                string targetFileShortcut = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), targetAssemblyName + ".url");
                if (File.Exists(targetFileShortcut))
                {
                    checkbox_SettingsWindowsStartup.IsChecked = true;
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to load the application settings: " + ex.Message);
                return false;
            }
        }
    }
}
