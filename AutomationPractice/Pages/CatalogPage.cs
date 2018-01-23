using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationPractice
{
    public class CatalogPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li/div/div[1]/div/a[1]/img")]
        public IWebElement imgProduct;


        public bool IsAtBlouses()
        {
            return Browser.GetActualSiteTitle.Contains("Tops - My Store");
        }

        public bool IsAtCasualDresses()
        {
            return Browser.GetActualSiteTitle.Contains("Casual Dresses - My Store");
        }

        public bool IsAtDresses()
        {
            return Browser.GetActualSiteTitle.Contains("Dresses - My Store");
        }

        public bool IsAtEveningDresses()
        {
            return Browser.GetActualSiteTitle.Contains("Evening Dresses - My Store");
        }

        public bool IsAtSummerDresses()
        {
            return Browser.GetActualSiteTitle.Contains("Summer Dresses - My Store");
        }

        public bool IsAtTops()
        {
            return Browser.GetActualSiteTitle.Contains("Tops - My Store");
        }

        public bool IsAtTshirts()
        {
            return Browser.GetActualSiteTitle.Contains("T-shirts - My Store");
        }

        public bool IsAtWoman()
        {
            return Browser.GetActualSiteTitle.Contains("Women - My Store");
        }

        public void ClickProduct()
        {
            imgProduct.Click();
        }
    }
}
