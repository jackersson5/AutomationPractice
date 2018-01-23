using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace AutomationPractice
{
   public class ContactPage
    {
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail;

        [FindsBy(How = How.Name, Using = "id_contact")]
        public IWebElement txtSubjectHeading;

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement txtMessage;

        [FindsBy(How = How.Id, Using = "submitMessage")]
        public IWebElement btnSubmitMessage;

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > ol > li")]
        public IWebElement txtValidation;

        [FindsBy(How = How.XPath,Using  = "//*[@id='center_column']/div/ol/li")]
        public IWebElement txtMessageValidation;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p")]
        public IWebElement txtConfirmationMessage;

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > ol > li")]
        public IWebElement txtSubjectHeadingValidation;


        public void SetSubjectHeading(string subjectHeading)
        {
            txtSubjectHeading.SendKeys(subjectHeading);
        }

        public void Send()
        {
            btnSubmitMessage.Click();
        }

        public void SetEmailAdress(string email)
        {
            txtEmail.SendKeys(email);
        }

        public void SetMessage(string message)
        {
            txtMessage.SendKeys(message);
        }

        public bool IsAt()
        {
            return Browser.GetActualSiteTitle.Contains("Contact - My Store");
        }

        public void CheckMessageValidation(string validation)
        {
            Assert.True(txtValidation.Text.Equals(validation));
        }

        public void CheckSubjectHeadingValidation(string validation)
        {
            Assert.True(txtSubjectHeadingValidation.Text.Equals(validation));
        }

        public void CheckEmailValidation(string validation)
        {
            Assert.True(txtValidation.Text.Equals(validation));
        }

        public void IsConfirmationMessageVisible(string message)
        {
            Assert.True(txtConfirmationMessage.Text.Equals(message));
        }
    }
}
