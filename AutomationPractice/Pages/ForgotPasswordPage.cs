using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace AutomationPractice
{
    public class ForgotPasswordPage
    {
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement btnLogin;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail;

        [FindsBy(How = How.XPath, Using = "//*[@id='form_forgotpassword']/fieldset/p/button")]
        public IWebElement btnRetrievePassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/div")]
        public IWebElement msgAlertError;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/p")]
        public IWebElement msgAlertSuccess;
        

        public void RetrievePassword()
        {
            btnRetrievePassword.Click();
        }

        public void SetEmailAdress(string email)
        {
            txtEmail.SendKeys(email);
        }

        public void IsSuccessMessage(string message)
        {
            Browser.WaitByXpath(10, "//*[@id='center_column']/div/p");
            Assert.True(msgAlertSuccess.Text.Contains(message));
        }

        public void CheckValidation(string validation)
        {
            Assert.True(msgAlertError.FindElement(By.TagName("li")).Text.Equals(validation)); 
        }

    }
 }

