using NvApi;
using System;
using System.Configuration;
using static ArnoldVinkCode.AVDisplayMonitor;

namespace NvidiaFpsLimitHelper
{
    class UpdateMaxFrameRate
    {
        //Update the max frame rate setting
        public static void UpdateMaxFrameRateSetting()
        {
            try
            {
                //Get the current target monitor
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
                    AppTray.NotifyIcon.Text = "Nvidia Fps Limit Helper (" + targetRefreshRate + "fps)";
                    App.vMainWindow.textblock_ApplicationStatus.Text = "Status: adjusted the maximum frame rate to " + targetRefreshRate + "fps at " + DateTime.Now.ToShortTimeString();
                }
                else
                {
                    AppTray.NotifyIcon.Text = "Nvidia Fps Limit Helper (?fps)";
                    App.vMainWindow.textblock_ApplicationStatus.Text = "Status: failed to adjust the maximum frame rate to " + targetRefreshRate + "fps at " + DateTime.Now.ToShortTimeString();
                }
            }
            catch { }
        }
    }
}