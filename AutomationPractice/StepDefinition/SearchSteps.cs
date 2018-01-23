using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"I am on Home page")]
        public void GivenIAmOnHomePage()
        {
            Browser.OpenHomePage();
        }
        
        [When(@"I enter a '(.*)'")]
        public void WhenIEnterA(string productName)
        {
            Pages.Navigation.SetProductName(productName);
        }
        
        [When(@"I click the search icon")]
        public void WhenIClickTheSearchIcon()
        {
            Pages.Navigation.Search();
        }
        
        [Then(@"List of products should be visible")]
        public void ThenListOfProductsShouldBeVisible()
        {
            Pages.Search.IsProductOnList();
        }
        
        [Then(@"No product should be found")]
        public void ThenNoProductShouldBeFound()
        {
            Pages.Search.IsNoProductOnList();
        }
    }
}
