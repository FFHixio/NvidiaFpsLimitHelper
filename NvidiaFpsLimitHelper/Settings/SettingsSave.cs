using System;
using System.Diagnostics;
using static NvidiaFpsLimitHelper.AppSettings;
using static NvidiaFpsLimitHelper.UpdateMaxFrameRate;

namespace NvidiaFpsLimitHelper
{
    public partial class MainWindow
    {
        //Save - Application Settings
        void Settings_Save()
        {
            try
            {
                slider_SettingsDisplayMonitor.ValueChanged += (sender, e) =>
                {
                    int monitorNumber = Convert.ToInt32(slider_SettingsDisplayMonitor.Value);
                    textblock_SettingsDisplayMonitor.Text = textblock_SettingsDisplayMonitor.Tag.ToString() + monitorNumber;
                    Setting_Save("DisplayMonitor", monitorNumber.ToString());
                    UpdateMaxFrameRateSetting();
                };

                slider_SettingsMaxFpsOffset.ValueChanged += (sender, e) =>
                {
                    int maxFpsOffset = Convert.ToInt32(slider_SettingsMaxFpsOffset.Value);
                    textblock_SettingsMaxFpsOffset.Text = textblock_SettingsMaxFpsOffset.Tag.ToString() + maxFpsOffset;
                    Setting_Save("MaxFpsOffset", maxFpsOffset.ToString());
                    UpdateMaxFrameRateSetting();
                };

                checkbox_SettingsWindowsStartup.Click += delegate { ManageShortcutStartup(); };
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to save the application settings: " + ex.Message);
            }
        }
    }
}