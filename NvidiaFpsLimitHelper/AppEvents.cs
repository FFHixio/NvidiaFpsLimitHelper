using System;
using System.Diagnostics;
using static NvidiaFpsLimitHelper.UpdateDisplayMonitors;
using static NvidiaFpsLimitHelper.UpdateMaxFrameRate;

namespace NvidiaFpsLimitHelper
{
    class AppEvents
    {
        //Event - System display settings changed
        public static void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("System display settings changed.");

                //Update the display monitors
                UpdateDisplayMonitorsCount();

                //Update the max frame rate setting
                UpdateMaxFrameRateSetting();
            }
            catch { }
        }
    }
}