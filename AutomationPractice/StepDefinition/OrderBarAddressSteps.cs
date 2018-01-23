using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class OrderBarAddressSteps
    {
        

        [Given(@"I am on adress window being logged in")]
        public void GivenIAmOnAdressWindowBeingLoggedIn()
        {
            Browser.ClearCache();
            Pages.Order.GotoAddress();
        }
        
        [When(@"I click Update delivery address")]
        public void WhenIClickUpdateDeliveryAddress()
        {
            Pages.Order.UpdateDeliveryAddress();
        }
        
        [When(@"I change city name")]
        public void WhenIChangeCityName()
        {
            Pages.Registration.txtCity.Clear();
            Pages.Registration.txtCity.SendKeys("changed");
        }

        [When(@"I click Save")]
        public void WhenIClickSave()
        {
            Pages.Registration.Save();
        }
        
        [When(@"I press Update billing address")]
        public void WhenIPressUpdateBillingAddress()
        {
            Pages.Order.UpdateBillingAddress();
        }
        
        [When(@"I change Address")]
        public void WhenIChangeAddress()
        {
            Pages.Registration.txtAdressAdress.Clear();
            Pages.Registration.txtAdressAdress.SendKeys("changed");
        }

        [Then(@"City name should be updated")]
        public void ThenCityNameShouldBeUpdated()
        {
            Pages.Order.txtCity.Text.StartsWith("changed");
        }
        
        [Then(@"I should back on address window")]
        public void ThenIShouldBackOnAddressWindow()
        {
            Pages.Order.IsAtAddress();
        }
        
        [Then(@"Address name should be updated")]
        public void ThenAddressNameShouldBeUpdated()
        {
            Pages.Order.txtCity.Text.StartsWith("changed");
            Browser.ClearCache();
        }
    }
}
