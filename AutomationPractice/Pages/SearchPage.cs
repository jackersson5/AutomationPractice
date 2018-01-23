using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace AutomationPractice
{
    public class SearchPage
    {
        [FindsBy(How = How.CssSelector, Using = "#center_column > h1 > span")]
        public IWebElement txtResult;


        public void IsNoProductOnList()
        {
            Assert.True(txtResult.Text.StartsWith("0"));
        }

        public void IsProductOnList()
        {
            Assert.False(txtResult.Text.StartsWith("0"));
        }
    }
}




