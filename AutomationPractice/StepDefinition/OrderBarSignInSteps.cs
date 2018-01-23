using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class OrderBarSignInSteps
    {
        [Given(@"I am on Sign In window being not logged in")]
        public void GivenIAmOnSignInWindowBeingNotLoggedIn()
        {
            Browser.ClearCache();
            Pages.Order.GoToSignInWindowNotLoggedIn();
        }
        
        [When(@"I enter valid email '(.*)' and password '(.*)'")]
        public void WhenIEnterValidEmailAndPassword(string email, string password)
        {
            Pages.Authentication.SetEmailAndPassword(email, password);
        }
        
        [When(@"I Click Sign In")]
        public void WhenIClickSignIn()
        {
            Pages.Authentication.ClickSignIn();
        }
        
        [Then(@"I should be on Address window")]
        public void ThenIShouldBeOnAddressWindow()
        {
            Pages.Order.IsAtAddress();
        }
    }
}
