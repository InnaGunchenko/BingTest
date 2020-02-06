using BingFrame.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BingSpcFlw
{
    [Binding]
    public class BingSearchSpecFlowSteps
    {
        [When(@"click on (.*) on (.*)")]
        public void WhenSelectInSearchResults(string element, string page)
        {
            MapPages.Page[page].Value.Click(MapPages.Page[page].Value.Elements[element]);
        }
        
        [Then(@"I am presented with the ""(.*)"" homepage (.*)")]
        public void ThenIAmPresentedWithPage(string title, string page)
        {
            Assert.That(MapPages.Page[page].Value.Title.Contains(title));
        }
    }
}
