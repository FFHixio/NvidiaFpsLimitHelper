using Microsoft.Win32;
using NvApi;
using System;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using static ArnoldVinkCode.AVDisplayMonitor;

namespace NvidiaFpsLimitHelper
{
    public partial class MainWindow : Window
    {
        //Window Initialize
        public MainWindow() { InitializeComponent(); }

        //Window Initialized
        protected override void OnSourceInitialized(EventArgs e)
        {
            try
            {
                //Check - Application Settings
                Settings_Check();
                Settings_Load();
                Settings_Save();

                //Update the max frame rate setting
                UpdateMaxFrameRateSetting();

                //Check if display settings has changed
                SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
            }
            catch { }
        }

        //Event display settings changed
        public void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            try
            {
                //Update the display monitor count
                slider_SettingsDisplayMonitor.Maximum = Screen.AllScreens.Count();

                //Update the max frame rate setting
                UpdateMaxFrameRateSetting();
            }
            catch { }
        }

        //Update the max frame rate setting
        private void UpdateMaxFrameRateSetting()
        {
            try
            {
                //Get the current active screen
                int monitorNumber = Convert.ToInt32(ConfigurationManager.AppSettings["DisplayMonitor"]);

                //Get the monitor refresh rate
                DisplayMonitorSettings displayMonitorSettings = GetScreenSettings(monitorNumber);

                //Adjust the maximum frame rate
                int targetRefreshRate = displayMonitorSettings.RefreshRate;
                int maxFpsOffset = Convert.ToInt32(ConfigurationManager.AppSettings["MaxFpsOffset"]);
                targetRefreshRate += maxFpsOffset;
                bool adjustedFps = NvApiWrapper.UpdateMaxFrameRate(targetRefreshRate);

                //Update the status text
                if (adjustedFps)
                {
                    textblock_ApplicationStatus.Text = "Status: adjusted the maximum frame rate to: " + targetRefreshRate + "fps";
                }
                else
                {
                    textblock_ApplicationStatus.Text = "Status: failed to adjust the maximum frame rate to: " + targetRefreshRate + "fps";
                }
            }
            catch { }
        }
    }
}