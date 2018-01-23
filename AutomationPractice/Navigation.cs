using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;


namespace AutomationPractice
{
    public class Navigation
    {
        //Navigation class -- here is navigation not related to a specific page
       
         //--TOP

        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement signIn;

        [FindsBy(How = How.CssSelector, Using = "#contact-link > a")]
        public IWebElement txtContactUs;

        //--Search

        [FindsBy(How = How.Id, Using = "search_query_top")]
        public IWebElement txtSearch;

        [FindsBy(How = How.Name, Using = "submit_search")]
        public IWebElement btnSubmit;

        //--Cart

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[3]/div/div/div[3]/div/a")]
        public IWebElement cart;

        //--Navbar

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(1) > a")]
        public IWebElement txtWomen;

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(1) > ul > li:nth-child(1) > a")]
        public IWebElement txtTops;

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(3) > a")]
        public IWebElement txtTshirts;

        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[1]/ul/li[1]/ul/li[2]/a")]
        public IWebElement txtBlouses;

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(2) > a")]
        public IWebElement txtDresses;

        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[2]/ul/li[1]/a")]
        public IWebElement txtCasualDresses;

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(2) > ul > li:nth-child(3) > a")]
        public IWebElement txtSummerDresses;

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(2) > ul > li:nth-child(2) > a")]
        public IWebElement txtEveningDresses;

        //--TOP 
        public void SignIn()
        {
            signIn.Click();
        }

        public void ContactUs()
        {
            txtContactUs.Click();
        }

        //--Search 
        public void Search()
        {
            btnSubmit.Click();
        }

        public void SetProductName(string productname)
        {
             txtSearch.SendKeys(productname);
        }

        //--Cart
        public void GoToCart()
        {
            cart.Click();
        }
        
        //--Navbar
        public void ClickWoman()
        {
            txtWomen.Click();
        }

        public void ClickTshirts()
        {
            txtTshirts.Click();
        }

        public void ClickBlouses()
        {
            txtBlouses.Click();
        }

        public void ClickDresses()
        {
            txtDresses.Click();
        }

        public void ClickCasualDresses()
        {
            txtCasualDresses.Click();
        }

        public void ClickEveningDresses()
        {
            txtEveningDresses.Click();
        }

        public void ClickSummerDresses()
        {
            txtSummerDresses.Click();
        }

        public void ClickTops()
        {
            txtTops.Click();
        }
    }
}
