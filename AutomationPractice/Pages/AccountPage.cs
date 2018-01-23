
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace AutomationPractice
{
    public class AccountPage
    {

        [FindsBy(How = How.CssSelector, Using = "#header > div.nav > div > div > nav > div:nth-child(2) > a")]
        public IWebElement btnSignOut;

        public void SignOut()
        {
            btnSignOut.Click();
        }

        public bool IsAt()
        {
            return Browser.GetActualSiteTitle.Contains("My account - My Store");
        }
    }
}



