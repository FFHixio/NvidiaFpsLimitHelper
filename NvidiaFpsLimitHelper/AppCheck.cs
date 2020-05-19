using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace NvidiaFpsLimitHelper
{
    class AppCheck
    {
        //Check the application status
        public static void LaunchCheck(string applicationName, string processName)
        {
            try
            {
                Debug.WriteLine("Checking application status.");

                //Check if application is already running
                if (Process.GetProcessesByName(processName).Length > 1)
                {
                    Debug.WriteLine("Application is already running.");
                    Environment.Exit(0);
                    return;
                }

                //Check for missing application files
                string[] applicationFiles = { "NvidiaFpsLimitHelper.exe.Config" };
                foreach (string checkFile in applicationFiles)
                {
                    if (!File.Exists(checkFile))
                    {
                        MessageBox.Show("File: " + checkFile + " could not be found, please check your installation.", applicationName);
                        Environment.Exit(0);
                        return;
                    }
                }
            }
            catch { }
        }
    }
}