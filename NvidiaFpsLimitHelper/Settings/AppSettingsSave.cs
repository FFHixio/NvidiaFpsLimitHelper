using System.Configuration;

namespace NvidiaFpsLimitHelper
{
    public partial class AppSettings
    {
        //Save - Application Setting
        public static void Setting_Save(string name, string value)
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