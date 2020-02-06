using BingFrame;
using BingFrame.Pages;
using System;
using TechTalk.SpecFlow;

namespace BingSpcFlw.Steps
{
    [Binding]
    public class SearchResultsOnRightSteps
    {
        [Given(@"I typed (.*) in (.*) on (.*)")]
        public void GivenITypedTextInElementOnPage(string text, string element, string page)
        {
             MapPages.Page[page].Value.Type(text, MapPages.Page[page].Value.Elements[element]);
        }
    }
}
