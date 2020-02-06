using BingFrame;
using BingFrame.Framework;
using BingFrame.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BingNUnitTesting
{
    [TestFixture]
    public class BingTests
    {
        int indexLocal;
        IWebDriver driver;
        static DriverFactory driverFactory;
        static MapPages mapPages;

        [OneTimeSetUp]
        public void BeforeTestSuit()
        {
            switch (AppSettings.Settings.Locale)
            {
                case Names.US: indexLocal = 0; break;
                case Names.UA: indexLocal = 1; break;
                default: break;
            }

            driverFactory = new DriverFactory();
            driver = driverFactory.CreateDriver();
            mapPages = new MapPages(driver);
            MapPages.Page["BingPage"].Value.NavigateTo(AppSettings.Settings.Url);
        }

        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            MapPages.Page["BingPage"].Value.Close();
        }

        #region Displayed Test

        [Test]
        public void Bing_Images_Displayed_Test()
        {
            foreach (var key in MapPages.Page["BingPage"].Value.Elements.Keys)
            {
                Assert.That(MapPages.Page["BingPage"].Value.IsDisplayed((MapPages.Page["BingPage"].Value.Elements[key])), string.Format("Element {0} is not displayed", key));
            }
        }
        
        #endregion
        
        #region Text Correct Test
        
        [Test]
        public void Bing_Images_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["Images"]), Is.EqualTo(Names.Images[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Images[indexLocal]));
        }

        [Test]
        public void Bing_SignIn_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["SignIn"]), Is.EqualTo(Names.SignIn[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.SignIn[indexLocal]));
        }

        [Test]
        public void Bing_Info_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["Info"]), Is.EqualTo(Names.Info[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Info[indexLocal]));
        }

        [Test]
        public void Bing_PrivacyAndCookies_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["PrivacyAndCookies"]), Is.EqualTo(Names.PrivacyAndCookies[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.PrivacyAndCookies[indexLocal]));
        }
        
        [Test]
        public void Bing_Legal_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["Legal"]), Is.EqualTo(Names.Legal[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Legal[indexLocal]));
        }

        [Test]
        public void Bing_Advertise_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["Advertise"]), Is.EqualTo(Names.Advertise[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Advertise[indexLocal]));
        }

        [Test]
        public void Bing_AboutOurAds_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["AboutOurAds"]), Is.EqualTo(Names.AboutOurAds[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.AboutOurAds[indexLocal]));
        }

        [Test]
        public void Bing_HelpLink_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["HelpLink"]), Is.EqualTo(Names.Help[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Advertise[indexLocal]));
        }

        [Test]
        public void Bing_Feedback_TextCorrect_Test()
        {
            Assert.That(MapPages.Page["BingPage"].Value.GetText(MapPages.Page["BingPage"].Value.Elements["Feedback"]), Is.EqualTo(Names.Feedback[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Advertise[indexLocal]));
        }

        #endregion

        #region Сheck search result bottom and right

        [Test]
        public void Check_SearchResultsOnRight_CountElements_Test()
        {
            MapPages.Page["BingSearchPage"].Value.EnterQuerySearch(Names.UrlBing, Names.SearchQueryText, MapPages.Page["BingSearchPage"].Value.Elements["SearchResultsOnRight"]);
            Assert.AreEqual(Names.Eight, MapPages.Page["BingSearchPage"].Value.CountElements(MapPages.Page["BingSearchPage"].Value.Elements["SearchResultsOnRight"]));
        }

        [Test]
        public void Check_SearchResultsOnBottom_CountElements_Test()
        {
            MapPages.Page["BingSearchPage"].Value.EnterQuerySearch(Names.UrlBing, Names.SearchQueryText, MapPages.Page["BingSearchPage"].Value.Elements["SearchResultsOnBottom"]);
            Assert.AreEqual(Names.Eight, MapPages.Page["BingSearchPage"].Value.CountElements(MapPages.Page["BingSearchPage"].Value.Elements["SearchResultsOnBottom"]));
        }

        #endregion

        #region Check search results on first page

        [Test]
        public void Check_SearchResultsOnFirstPage_CountElements_Test()
        {
            MapPages.Page["BingSearchPage"].Value.EnterQuerySearch(Names.UrlBing, Names.SearchQueryText, MapPages.Page["BingSearchPage"].Value.Elements["SearchResultsOnFirstPage"]);
            Assert.AreEqual(Names.Ten, MapPages.Page["BingSearchPage"].Value.CountElements(MapPages.Page["BingSearchPage"].Value.Elements["SearchResultsOnFirstPage"]));
        }
        
        #endregion
    }
}
