using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace BingFrame.Pages
{
    public class MapPages
    {
        public static Dictionary<string, Lazy<BasePage>> Page;
        public MapPages(IWebDriver driver)
        {
            Page = new Dictionary<string, Lazy<BasePage>>()
            {
                { "BingPage", new Lazy<BasePage>(()=> new BingPage(driver)) } ,
                { "BingSearchPage", new Lazy<BasePage> (()=> new BingSearchPage(driver))},
                { "BingSignInPage", new Lazy<BasePage> (()=> new BingSignInPage(driver))},
                { "SpecFlowPage", new Lazy<BasePage> (()=> new SpecFlowPage(driver))}
            };
        }
    }
}
