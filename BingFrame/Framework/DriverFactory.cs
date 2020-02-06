using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace BingFrame.Framework
{
    public class DriverFactory
    {
        public IWebDriver CreateDriver()
        {
            string argumentLanguage = string.Format("--lang={0}", AppSettings.Settings.Locale);

            switch (AppSettings.Settings.Browser)
            {
                case Names.Chrome:
                    OpenQA.Selenium.Chrome.ChromeOptions chromeOptions = new OpenQA.Selenium.Chrome.ChromeOptions();
                    chromeOptions.AddArguments(argumentLanguage);
                    return new ChromeDriver(chromeOptions);
                case Names.FireFox:
                    OpenQA.Selenium.Firefox.FirefoxOptions firefoxOptions = new OpenQA.Selenium.Firefox.FirefoxOptions();
                    firefoxOptions.AddArguments(argumentLanguage);
                    return new OpenQA.Selenium.Firefox.FirefoxDriver();
                default:
                    throw new ArgumentException($"Browser not yet implemented: {AppSettings.Settings.Browser}");
            }
        }
    }
}
