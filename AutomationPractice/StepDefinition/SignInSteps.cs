using System;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class SignInSteps
    {

        [AfterScenario("LoginProperly")]
        public void PerformAfterStep()
        {
            Pages.Account.SignOut();
        }

        [Given(@"I'm on Authentication page")]
        public void GivenIMOnAuthenticationPage()
        {
            Browser.ClearCache();
            Browser.OpenAuthenticationPage();
        }
        
        [Given(@"I am logged in with email '(.*)' and password '(.*)'")]
        public void GivenIAmLoggedInWithAnd(string email, string password)
        {
            Pages.Account.IsAt();
        }
        
        [When(@"I enter email '(.*)' and password '(.*)'")]
        public void WhenIEnterAnd(string email, string password)
        {
            Pages.Authentication.SetEmailAndPassword(email,password);
        }
        
        [When(@"I click Sign In")]
        public void WhenIClickSignIn()
        {
            Pages.Authentication.ClickSignIn();
        }
        
        [When(@"I click Sign out")]
        public void WhenIClickSignOut()
        {
            Pages.Account.SignOut();
        }
        
        [Then(@"I should be logged into my account")]
        public void ThenIShouldBeLoggedIntoMyAccount()
        {
            Pages.Account.IsAt();
        }
        
        [Then(@"I should be logged out")]
        public void ThenIShouldBeLoggedOut()
        {
            Pages.Authentication.IsAt();
        }
        
        [Then(@"I should see ""(.*)""")]
        public void ThenIShouldSee(string validation)
        {
            Pages.Authentication.CheckValidation(validation);
        }
    }
}
