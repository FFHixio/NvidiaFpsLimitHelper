using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;

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
                //Application Settings
                Settings_Load();
                Settings_Save();

                //Update version text
                textblock_ApplicationVersion.Text = "Application made by Arnold Vink, version: v" + Assembly.GetEntryAssembly().FullName.Split('=')[1].Split(',')[0];
            }
            catch { }
        }

        //Window Closing
        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                e.Cancel = true;
                this.Hide();
            }
            catch { }
        }
    }
}