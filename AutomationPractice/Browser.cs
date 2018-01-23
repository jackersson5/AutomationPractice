using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice
{
    public class Browser: Pages
    {
        private static string HomePage           = "http://automationpractice.com/";
        private static string AuthenticationPage = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        private static string WomenPage          = "http://automationpractice.com/index.php?id_category=3&controller=category";
        private static string TopsPage           = "http://automationpractice.com/index.php?id_category=4&controller=category";
        private static string TshirtsPage        = "http://automationpractice.com/index.php?id_category=5&controller=category";
        private static string BlousesPage        = "http://automationpractice.com/index.php?id_category=7&controller=category";
        private static string DressesPage        = "http://automationpractice.com/index.php?id_category=8&controller=category";
        private static string CasualDressesPage  = "http://automationpractice.com/index.php?id_category=9&controller=category";
        private static string EveningDressesPage = "http://automationpractice.com/index.php?id_category=10&controller=category";
        private static string SummerDressesPage  = "http://automationpractice.com/index.php?id_category=11&controller=category";
        private static string ContactPage        = "http://automationpractice.com/index.php?controller=contact";
        

        public static void Close()
        {
            driver.Close();
        }


        //All waits ToDo

        public static void WaitById(int time,string element) 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
        }

        public static void WaitByCssSelector(int time, string element) 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }

        public static void WaitByXpath(int time, string element ) 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
        }

        public static void WaitByClassName(int time, string element) 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(element)));
        }

        public static void Quit()
        {
            driver.Quit();
        }

        public static void ClearCache()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public static string GetActualSiteTitle
        {
            get { return driver.Title; }
        }

        public static string GetActualSiteUrl
        {
            get { return driver.Url; }
        }
        
        public static void OpenHomePage()
        {
            driver.Navigate().GoToUrl(HomePage);
        }
        public static void OpenAuthenticationPage()
        {
            driver.Navigate().GoToUrl(AuthenticationPage);
        }

        public static void OpenWomenPage()
        {
            driver.Navigate().GoToUrl(WomenPage);
        }

        public static void OpenDressesPage()
        {
            driver.Navigate().GoToUrl(DressesPage);
        }

        public static void OpenCasualDressesPage()
        {
            driver.Navigate().GoToUrl(CasualDressesPage);
        }

        public static void OpenContactPage()
        {
            driver.Navigate().GoToUrl(ContactPage);
        }

        public static void OpenForgotPasswordPage()
        {
            driver.Navigate().GoToUrl(AuthenticationPage);
            Pages.Authentication.txtForgotPassword.Click();
        }
    }
}