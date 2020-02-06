using OpenQA.Selenium;
using System.Collections.Generic;

namespace BingFrame
{
    public class BingPage : BasePage
    {
        public BingPage(IWebDriver driver) : base(driver) { }

        public override Dictionary<string, By> Elements { get; set; } = new Dictionary<string, By>()
        {
            {"Images", By.CssSelector("a.scopebar_link")},
            { "DotsMenuContainer", By.CssSelector("li#dots_overflow_menu_container")},
            { "SignIn",  By.CssSelector("span#id_s")},
            { "Settings", By.CssSelector("a#id_sc")},
            { "SearchInput", By.CssSelector("input#sb_form_q")},
            { "SearchUsingAnImg", By.CssSelector("img#sbi_b")},
            { "SearchTheWeb", By.XPath("//label[@class='search icon tooltip']")},
            { "HeadlineIcon", By.CssSelector("a#headline_link>div.icon")},
            { "Info", By.CssSelector("a#headline_link>div#headline")},
            { "LeftNav", By.CssSelector("div.nav>a#leftNav")},
            { "RightNav", By.CssSelector("div.nav>a#rightNav")},
            { "PrivacyAndCookiesLink", By.CssSelector("#footer a#privacy")},
            { "LegalLink", By.CssSelector("#footer a#legal")},
            { "AdvertiseLink", By.CssSelector("#footer ul > li:nth-child(3) > a")},
            { "AboutOurAdsLink", By.CssSelector("#footer ul > li:nth-child(4) > a")},
            { "HelpLink", By.CssSelector("#footer ul > li:nth-child(5) > a")},
            { "FeedbackLink", By.CssSelector("#footer a#sb_feedback")},
            { "FooterList", By.XPath("//footer[@id='footer']//ul/li")}
        };
    }
}