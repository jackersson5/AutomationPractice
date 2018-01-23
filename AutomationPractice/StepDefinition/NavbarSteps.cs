using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class NavbarSteps
    {
        Actions builder = new Actions(Pages.driver);

        [Given(@"I am on Authentication page")]
        public void GivenIAmOnAuthenticationPage()
        {
            Browser.OpenAuthenticationPage();
        }
        
        [Given(@"I am on Homepage")]
        public void GivenIAmOnHomepage()
        {
            Browser.OpenHomePage();   
        }
        
        [Given(@"I am on Women page")]
        public void GivenIAmOnWomenPage()
        {
            Browser.OpenWomenPage();
        }
        
        [Given(@"I am on Casual Dresses page")]
        public void GivenIAmOnCasualDressesPage()
        {
            Browser.OpenCasualDressesPage();
        }
        
        [Given(@"I am on Contact page")]
        public void GivenIAmOnContactPage()
        {
            Browser.OpenContactPage();
        }
        
        [When(@"I click Woman")]
        public void WhenIClickWoman()
        {
            Pages.Navigation.ClickWoman();
        }
        
        [When(@"I mouse over Woman and click Tops")]
        public void WhenIMouseOverWomanAndClickTops()
        {
            builder.MoveToElement(Pages.Navigation.txtTops).Perform();
        }
        
        [When(@"I mouse over Woman and click t-shirts")]
        public void WhenIMouseOverWomanAndClickT_Shirts()
        {
            builder.MoveToElement(Pages.Navigation.txtTshirts).Perform();
        }
        
        [When(@"I mouse over Woman and click Blouses")]
        public void WhenIMouseOverWomanAndClickBlouses()
        {
            builder.MoveToElement(Pages.Navigation.txtBlouses).Perform();
        }
        
        [When(@"I click Dresses")]
        public void WhenIClickDresses()
        {
            Pages.Navigation.ClickDresses();
        }
        
        [When(@"I mouse over Dresses and click Casual dresses")]
        public void WhenIMouseOverDressesAndClickCasualDresses()
        {
            builder.MoveToElement(Pages.Navigation.txtCasualDresses).Perform();
        }
        
        [When(@"I mouse over Dresses and click Evening dresses")]
        public void WhenIMouseOverDressesAndClickEveningDresses()
        {
            builder.MoveToElement(Pages.Navigation.txtEveningDresses).Perform();
        }
        
        [When(@"I mouse over Dresses and click Summer dresses")]
        public void WhenIMouseOverDressesAndClickSummerDresses()
        {
            builder.MoveToElement(Pages.Navigation.txtSummerDresses).Perform();
        }
        
        [Then(@"I should be redirected to Woman page")]
        public void ThenIShouldBeRedirectedToWomanPage()
        {
            Pages.Catalog.IsAtWoman();
        }
        
        [Then(@"I should be redirected to Tops page")]
        public void ThenIShouldBeRedirectedToTopsPage()
        {
            Pages.Catalog.IsAtTops();
        }
        
        [Then(@"I should be redirected to Tshirts page")]
        public void ThenIShouldBeRedirectedToTshirtsPage()
        {
            Pages.Catalog.IsAtTshirts();
        }
        
        [Then(@"I should be redirected to Blouses page")]
        public void ThenIShouldBeRedirectedToBlousesPage()
        {
            Pages.Catalog.IsAtBlouses();
        }
        
        [Then(@"I should be redirected to Dresses page")]
        public void ThenIShouldBeRedirectedToDressesPage()
        {
            Pages.Catalog.IsAtDresses();
        }
        
        [Then(@"I should be redirected to Casual Dresses page")]
        public void ThenIShouldBeRedirectedToCasualDressesPage()
        {
            Pages.Catalog.IsAtCasualDresses();
        }
        
        [Then(@"I should be redirected to Evening Dresses page")]
        public void ThenIShouldBeRedirectedToEveningDressesPage()
        {
            Pages.Catalog.IsAtEveningDresses();
        }
        
        [Then(@"I should be redirected to Summer Dresses page")]
        public void ThenIShouldBeRedirectedToSummerDressesPage()
        {
            Pages.Catalog.IsAtSummerDresses();
        }
    }
}
