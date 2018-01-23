using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationPractice
{
    public class CartPage
    {
        
        [FindsBy(How = How.XPath, Using = "//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")]
        public IWebElement btnProceed;

        [FindsBy(How = How.XPath, Using = "//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span")]
        public IWebElement btnContinue;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[3]/div/div/div[3]/div/div/div/div/dl/dt/span/a")]
        public IWebElement btnRemove;

        [FindsBy(How = How.XPath, Using = "//*[@id='layer_cart']/div[1]/div[1]/h2")]
        public IWebElement msgSuccess;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[3]/div/div/div[3]/div/a/span[5]")]
        public IWebElement txtEmpty;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[3]/div/div/div[3]/div/a")]
        public IWebElement cartViewWindow;


        public void ProceedToCheckout()
        {
            Browser.WaitByXpath(10, "//*[@id='layer_cart']/div[1]/div[2]/div[4]/a");
            btnProceed.Click();
        }

        public void ContinueShopping()
        {
            Browser.WaitByXpath(10, "//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span");
            btnContinue.Click();
        }

        public void RemoveProductFromCart()
        {
            Actions actions = new Actions(Browser.driver);
            IWebElement cartView = cartViewWindow;
            actions.MoveToElement(cartView);

            IWebElement remove = btnRemove;
            actions.MoveToElement(remove);
            actions.Click().Build().Perform();
        }

        public void IsProductAdded()
        {
            Browser.WaitByXpath(10, "//*[@id='layer_cart']/div[1]/div[1]/h2");
            Assert.True(msgSuccess.Text.Equals("Product successfully added to your shopping cart"));
        }

        public void IsCartEmpty()
        {
            Browser.WaitByXpath(10, "//*[@id='header']/div[3]/div/div/div[3]/div/a/span[5]");
            Assert.True(txtEmpty.Text.Equals("(empty)"));
        }
    }
}
