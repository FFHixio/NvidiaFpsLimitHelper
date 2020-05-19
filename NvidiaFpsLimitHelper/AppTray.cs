using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace NvidiaFpsLimitHelper
{
    class AppTray
    {
        //Tray Variables
        public static NotifyIcon NotifyIcon = new NotifyIcon();
        private static ContextMenu ContextMenu = new ContextMenu();

        //Create application tray menu
        public static void CreateTrayMenu()
        {
            try
            {
                Debug.WriteLine("Creating application tray menu.");

                //Create a context menu for systray.
                ContextMenu.MenuItems.Add("Settings", OnSettings);
                ContextMenu.MenuItems.Add("Website", OnWebsite);
                ContextMenu.MenuItems.Add("Exit", OnExit);

                //Initialize the tray notify icon. 
                NotifyIcon.Text = "Nvidia Fps Limit Helper";
                NotifyIcon.Icon = new Icon(Assembly.GetEntryAssembly().GetManifestResourceStream("NvidiaFpsLimitHelper.Assets.AppIcon.ico"));

                //Handle Double Click event
                NotifyIcon.DoubleClick += NotifyIcon_DoubleClick;

                //Add menu to tray icon and show it.  
                NotifyIcon.ContextMenu = ContextMenu;
                NotifyIcon.Visible = true;
            }
            catch { }
        }

        private static void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                App.vMainWindow.Show();
            }
            catch { }
        }

        private static void OnSettings(object sender, EventArgs e)
        {
            try
            {
                App.vMainWindow.Show();
            }
            catch { }
        }

        private static void OnWebsite(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://projects.arnoldvink.com");
            }
            catch { }
        }

        private static void OnExit(object sender, EventArgs e)
        {
            try
            {
                AppStartup.Application_Exit();
            }
            catch { }
        }
    }
}