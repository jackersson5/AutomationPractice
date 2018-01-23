using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutomationPractice
{
    public class AuthenticationPage
    {
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail;

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPasswd;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement btnSubmitLogin;

        [FindsBy(How = How.CssSelector, Using = "#center_column > div.alert.alert-danger")]
        public IWebElement txtAlert;

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement txtEmailcreate;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement btnSubmitCreate;

        [FindsBy(How = How.XPath, Using = "//*[@id='login_form']/div/p[1]/a")]
        public IWebElement txtForgotPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div[1]/ol/li")]
        public IWebElement txtMessage;
        
        public void SetEmailAndPassword(String userName, String password)
        {
            Browser.WaitById(10, "email");
            Browser.WaitById(10, "passwd");

            txtEmail.SendKeys(userName);
            txtPasswd.SendKeys(password);
        }

        public void ClickSignIn()
        {
            Browser.WaitById(10, "SubmitLogin");
            btnSubmitLogin.Click();
        }

        public void SignIn(String email, String password)
        {
            SetEmailAndPassword(email,password);
            ClickSignIn();
        }

        public void CreateAnAccount()
        {
            btnSubmitCreate.Click();
        }

        public bool IsAt()
        {
            return Browser.GetActualSiteTitle.Contains("Login - My Store");
        }

        public void CheckValidation(string validation)
        {
            Browser.WaitByXpath(10, "//*[@id='center_column']/div[1]/ol/li");
            Assert.True(txtMessage.Text.Equals(validation));
        }

        public void CreateNewAccount()
        {
            Browser.OpenAuthenticationPage();
            txtEmailcreate.SendKeys(GeneratorEmail.GenerateEmailAddress());
            Pages.Authentication.CreateAnAccount();
        }

    }
}









