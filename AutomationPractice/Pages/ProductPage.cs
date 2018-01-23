 
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationPractice
{
    public class ProductPage
    {
        [FindsBy(How = How.TagName, Using = "Body")]
        public IWebElement body;

        [FindsBy(How = How.Name, Using = "Submit")]
        public IWebElement btnAddToCart;


        public void AddToCart()
        {
            btnAddToCart.Click();
        }

        public void IsAt()
        {
            Assert.IsTrue(body.GetAttribute("id").Contains("product"));
        }

    }
}
