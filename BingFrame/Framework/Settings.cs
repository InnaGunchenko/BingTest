using System.Configuration;

namespace BingFrame.Framework
{
    public class Settings
    {
        static string locale;
        static string url;
        static string browser;
        public string Browser { get { return browser; } }
        public string Locale { get { return locale; } }
        public string Url { get { return url; } }

        public Settings()
        {
            AppSettingsSection configAppSettings;
            Configuration config = ConfigurationManager.OpenExeConfiguration(this.GetType().Assembly.Location);
            configAppSettings = (AppSettingsSection)config.GetSection(Names.SectionAppSettings);
            browser = configAppSettings.Settings[Names.Browser].Value;
            locale = configAppSettings.Settings[Names.Locale].Value;
            url = configAppSettings.Settings[Names.UrlBing].Value;
        }
    }

    public static class AppSettings
    {
        static Settings settings;
        public static Settings Settings {get {return settings;} }

        static AppSettings()
        {
            settings = new Settings();
        }
    }
}
