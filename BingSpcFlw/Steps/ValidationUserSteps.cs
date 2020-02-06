using BingFrame;
using BingFrame.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BingSpcFlw
{
    [Binding]
    public class ValidationUserSteps
    {
        [Given(@"click on (.*) on (.*)")]
        public void GivenClickOnElement(string element, string page)
        {
            MapPages.Page[page].Value.Click(MapPages.Page[page].Value.Elements[element]);
        }

        [Then(@"I can see the (.*) on the (.*)")]
        public void ThenICanSeeTheElementOnPage(string element, string page)
        {
            Assert.That(MapPages.Page[page].Value.IsDisplayed(MapPages.Page[page].Value.Elements[element]));
        }
    }
}