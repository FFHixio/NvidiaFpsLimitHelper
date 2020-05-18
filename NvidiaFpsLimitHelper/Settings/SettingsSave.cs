using System;
using System.Configuration;
using System.Diagnostics;

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
                    SettingSave("DisplayMonitor", monitorNumber.ToString());
                    UpdateMaxFrameRateSetting();
                };

                slider_SettingsMaxFpsOffset.ValueChanged += (sender, e) =>
                {
                    int maxFpsOffset = Convert.ToInt32(slider_SettingsMaxFpsOffset.Value);
                    textblock_SettingsMaxFpsOffset.Text = textblock_SettingsMaxFpsOffset.Tag.ToString() + maxFpsOffset;
                    SettingSave("MaxFpsOffset", maxFpsOffset.ToString());
                    UpdateMaxFrameRateSetting();
                };
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to save the application settings: " + ex.Message);
            }
        }

        //Save - Application Setting
        void SettingSave(string name, string value)
        {
            try
            {
                Configuration configurationApplication = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configurationApplication.AppSettings.Settings.Remove(name);
                configurationApplication.AppSettings.Settings.Add(name, value);
                configurationApplication.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch { }
        }
    }
}