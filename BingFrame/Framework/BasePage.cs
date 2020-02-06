using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using TechTalk.SpecFlow;

namespace BingFrame
{
    public class BasePage
    {
        IWebDriver driver;

        public virtual Dictionary<string, By> Elements { get; set; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string Title
        {
            get
            {
                return driver.Title;
            }
        }

        public void Close()
        {
            driver.Close();
        }

        public void Maximize()
        {
            driver.Manage().Window.Maximize();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return driver.FindElements(locator);
            }
            catch
            {
                return null;
            }
        }

        public IWebElement FindElement(By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return driver.FindElement(locator);
            }
            catch
            {
                return null;
            }
        }

        public void Type(string inputText, By locator)
        {
            FindElement(locator).SendKeys(inputText);
        }

        public void Click(By locator)
        {
            FindElement(locator).Click();
        }

        public int CountElements(By locator)
        {
            return FindElements(locator).Count;
        }

        public bool Contains(By locator, string text)
        {
            bool w = FindElement(locator).Text.Contains(text);
            return FindElement(locator).Text.Contains(text);
        }

        public string FailureMessagePresent(By locator)
        {
            if (IsDisplayed(locator))
            {
                return GetText(locator);
            }
            return null;
        }

        public string GetText(By locator)
        {
            return FindElement(locator).Text;
        }

        public bool IsDisplayed(By locator)
        {
            try
            {
                IWebElement element = FindElement(locator);
                return element.Displayed && element.Enabled;
            }
            catch 
            {
                return false;
            }
        }

        public void EnterQuerySearch(string url, string searchQueryText, By locator)
        {
            this.Type(searchQueryText, locator);
            this.Type(Keys.Enter, locator);
        }
    }

}
