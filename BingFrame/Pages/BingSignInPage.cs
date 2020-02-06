using OpenQA.Selenium;
using System.Collections.Generic;

namespace BingFrame
{
    public class BingSignInPage : BasePage
    {
        public BingSignInPage(IWebDriver driver) : base(driver) { }
        public override Dictionary<string, By> Elements { get; set; } = new Dictionary<string, By>()
        {
            { "UserInput", By.Id("i0116")},
            { "PasswordInput", By.Id("i0118")}
        };
    }
}
