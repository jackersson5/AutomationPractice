using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"I am on the Register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            Pages.Authentication.CreateNewAccount();
        }
        
        [When(@"I click Register")]
        public void WhenIClickRegister()
        {
            Pages.Registration.ClickRegister();
        }
        
        //ToDo

        [When(@"I enter correct details to all required fields with following '(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)'")]
        public void WhenIEnterCorrectDetailsToAllRequiredFieldsWithFollowing(string PersonalFirstName, string PersonalLastName, string Email, string Password, string AddressFirstName, string
                                                                               AdressLastName, string Adress, string City, string State, string PostCode, string Country, string PhoneMobile, string Alias)
        {
            Pages.Registration.FillRequiredRegisterFields(PersonalFirstName, PersonalLastName, Email, Password, AddressFirstName,
                                               AdressLastName, Adress, City, State, PostCode, Country, PhoneMobile, Alias);
        }

        [Then(@"I should see error message about required fields")]
        public void ThenIShouldSeeErrorMessageAboutRequiredFields()
        {
            Pages.Registration.CheckValidation();
        }
        
        [Then(@"My account should be created and I should be redirected to it")]
        public void ThenMyAccountShouldBeCreatedAndIShouldBeRedirectedToIt()
        {
            Pages.Account.IsAt();
        }
    }
}
