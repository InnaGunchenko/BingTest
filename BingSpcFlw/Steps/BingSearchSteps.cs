using BingFrame.Framework;
using BingFrame.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BingSpcFlw
{
    [Binding]
    public class BingSearchSteps
    {
        [Given(@"I have navigated to (.*)")]
        public void GivenIHaveNavigatedToBingPage(string page)
        {
            MapPages.Page[page].Value.NavigateTo(AppSettings.Settings.Url);
        }

        [Given(@"I entered to (.*) on the (.*) and typed")]
        public void GivenIEnteredToPageOnElement(string page, string element, Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            MapPages.Page[page].Value.Type((String)data.SearchString, MapPages.Page[page].Value.Elements[element]);
        }

        [When(@"I press key enter on the (.*) on the (.*)")]
        public void WhenIPressKeyEnterOnElementOnPage(string element, string page)
        {
            MapPages.Page[page].Value.Type(Keys.Enter, MapPages.Page[page].Value.Elements[element]);
        }
        
        [Then(@"I should navigate to (.*) and (.*) elements (.*)")]
        public void ThenINavigateToPageAndCountElements(string page, int count, string element)
        {
            Assert.AreEqual(count, MapPages.Page[page].Value.CountElements(MapPages.Page[page].Value.Elements[element]));
        }
    }
}