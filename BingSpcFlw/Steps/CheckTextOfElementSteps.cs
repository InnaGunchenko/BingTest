using BingFrame;
using BingFrame.Pages;
using NUnit.Framework;
using System.Linq;
using TechTalk.SpecFlow;

namespace BingSpcFlw.Steps
{
    [Binding]
    public class CheckTextOfElementSteps
    {
        [Then(@"I search (.*) on (.*) and check text")]
        public void ThenICheckTextOfElement(string element, string page, Table table)
        {
            int i = 0;
            foreach (var item in MapPages.Page[page].Value.FindElements(MapPages.Page[page].Value.Elements[element]))
            {
                Assert.That(item.Text, Is.EqualTo(table.Rows[i].Values.ToArray()[0]), string.Format("Text {0} of the element is incorrectt", table.Rows[i].Values.ToArray()[0]));
                i++;
            }
        }
    }
}