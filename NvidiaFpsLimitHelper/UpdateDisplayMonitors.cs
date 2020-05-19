using System.Linq;
using System.Windows.Forms;

namespace NvidiaFpsLimitHelper
{
    class UpdateDisplayMonitors
    {
        //Update the display monitors
        public static void UpdateDisplayMonitorsCount()
        {
            try
            {
                //Update the display monitor count
                App.vMainWindow.slider_SettingsDisplayMonitor.Maximum = Screen.AllScreens.Count();
            }
            catch { }
        }
    }
}