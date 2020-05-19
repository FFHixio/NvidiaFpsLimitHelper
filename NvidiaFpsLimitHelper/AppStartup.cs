using Microsoft.Win32;
using System;
using System.Configuration;
using System.Diagnostics;
using static NvidiaFpsLimitHelper.UpdateDisplayMonitors;
using static NvidiaFpsLimitHelper.UpdateMaxFrameRate;

namespace NvidiaFpsLimitHelper
{
    class AppStartup
    {
        //Application Startup
        public static void Application_Startup()
        {
            try
            {
                Debug.WriteLine("Welcome to Nvidia Fps Limit Helper.");

                //Check the application status
                AppCheck.LaunchCheck("Nvidia Fps Limit Helper", "NvidiaFpsLimitHelper");

                //Check application settings
                AppSettings.Settings_Check();

                //Create application tray menu
                AppTray.CreateTrayMenu();

                //Update the display monitors
                UpdateDisplayMonitorsCount();

                //Update the max frame rate setting
                UpdateMaxFrameRateSetting();

                //Check if display settings changed
                SystemEvents.DisplaySettingsChanged += AppEvents.SystemEvents_DisplaySettingsChanged;

                //Show settings screen on first launch
                if (Convert.ToBoolean(ConfigurationManager.AppSettings["AppFirstLaunch"]))
                {
                    Debug.WriteLine("First launch, showing the settings screen.");
                    AppSettings.Setting_Save("AppFirstLaunch", "False");
                    App.vMainWindow.Show();
                }
            }
            catch { }
        }

        //Application Exit
        public static void Application_Exit()
        {
            try
            {
                Debug.WriteLine("Exiting application.");

                //Hide the tray icon
                AppTray.NotifyIcon.Visible = false;

                //Exit the application
                Environment.Exit(0);
            }
            catch { }
        }
    }
}