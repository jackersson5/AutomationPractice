using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class ForgotPasswordSteps
    {
        [Given(@"I am on Forgot Password page")]
        public void GivenIAmOnForgotPasswordPage()
        {
            Browser.ClearCache();
            Browser.OpenForgotPasswordPage();
        }
        
        [Given(@"I enter email '(.*)' adress")]
        public void GivenIEnterEmailAdress(string adress)
        {
            Pages.ForgotPassword.SetEmailAdress(adress);
        }
        
        [When(@"I click Retrieve Password")]
        public void WhenIClickRetrievePassword()
        {
            Pages.ForgotPassword.RetrievePassword();
        }

        [Then(@"Confirmation message ""(.*)"" \+ here your Adress appear")]
        public void ThenConfirmationMessageHereYourAdressAppear(string message)
        {
            Pages.ForgotPassword.IsSuccessMessage(message);
        }

        [Then(@"Email validation ""(.*)"" appears")]
        public void ThenEmailValidationAppears(string message)
        {
            Pages.ForgotPassword.CheckValidation(message);
        }
    }
}
