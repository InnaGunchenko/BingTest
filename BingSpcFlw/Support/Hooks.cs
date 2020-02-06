using BingFrame.Framework;
using BingFrame.Pages;
using BoDi;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BingSpcFlw
{
    [Binding]
    public class Hooks
    {
        readonly IObjectContainer container;
        IWebDriver driver;
        static DriverFactory driverFactory;
        static MapPages mapPages;

        public Hooks(IObjectContainer container)
        {
            this.container = container;          
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            driverFactory = new DriverFactory();
        }

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            driver = driverFactory.CreateDriver();
            container.RegisterInstanceAs(driver);
            mapPages = new MapPages(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver?.Dispose();
        }
    }
}
