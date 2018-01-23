using System;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class ContactSteps
    {
        string addressFromSignIn;

        [Given(@"I am on Contact us page")]
        public void GivenIAmOnContactUsPage()
        {
            Browser.OpenContactPage();
        }

        [When(@"I enter email '(.*)' and subjectHeading '(.*)'")]
        public void WhenIEnterEmailAndSubjectHeading(string email, string subjectHeading)
        {
            Pages.Contact.SetEmailAdress(email);
            Pages.Contact.SetSubjectHeading(subjectHeading);
        }

        [When(@"I click Send")]
        public void WhenIClickSend()
        {
            Pages.Contact.Send();
        }

        [When(@"I enter email '(.*)' and message '(.*)'")]
        public void WhenIEnterEmailAndMessage(string email, string message)
        {
            Pages.Contact.SetEmailAdress(email);
            Pages.Contact.SetMessage(message);
        }

        [When(@"I enter email, subjectHeading and message '(.*)','(.*)', '(.*)'")]
        public void WhenIEnterEmailSubjectHeadingAndMessage(string email, string subjectHeading, string message)
        {
            Pages.Contact.SetEmailAdress(email);
            Pages.Contact.SetSubjectHeading(subjectHeading);
            Pages.Contact.SetMessage(message);
        }

        [When(@"I Sign In using '(.*)' and '(.*)'")]
        public void WhenISignInUsingAnd(string signInEmailAdress, string password)
        {
            Browser.OpenAuthenticationPage();
            Pages.Authentication.SignIn(signInEmailAdress, password);
            addressFromSignIn = signInEmailAdress.ToString();
        }

        [When(@"I click Contact Us")]
        public void WhenIClickContactUs()
        {
            Pages.Navigation.ContactUs();
        }

        [Then(@"Message validation ""(.*)"" appears")]
        public void ThenMessageValidationAppears(string validation)
        {
            Pages.Contact.CheckMessageValidation(validation);
        }

        [Then(@"Email adress validation ""(.*)"" appears")]
        public void ThenEmailAdressValidationAppears(string validation)
        {
            Pages.Contact.CheckEmailValidation(validation);
        }

        [Then(@"Subject heading validation ""(.*)"" appears")]
        public void ThenSubjectHeadingValidationAppears(string validation)
        {
            Pages.Contact.CheckSubjectHeadingValidation(validation);
        }

        [Then(@"Successful message ""(.*)"" appears")]
        public void ThenSuccessfulMessageAppears(string message)
        {
            Pages.Contact.IsConfirmationMessageVisible(message);
        }

        [Then(@"The email adress field should be filled with email address from sign in")]
        public void ThenTheEmailAdressFieldShouldBeFilledWithEmailAddressFromSignIn()
        {
            Pages.Contact.txtEmail.Text.Contains(addressFromSignIn);
        }
    }
}

