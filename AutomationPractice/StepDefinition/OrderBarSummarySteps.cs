using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class OrderBarSummarySteps
    {
        [Given(@"I am on the summary screen and the cart contains some product")]
        public void GivenIAmOnTheSummaryScreenAndTheCartContainsSomeProduct()
        {
            Browser.ClearCache();
            Pages.Order.GoToSummaryScreenWithAProductInCart();
        }
        
        [When(@"I remove the product")]
        public void WhenIRemoveTheProduct()
        {
            Pages.Order.RemoveProduct();
        }
        
        [When(@"I add product")]
        public void WhenIAddProduct()
        {
            Pages.Order.AddProduct();
        }
        
        [When(@"I subtract product")]
        public void WhenISubtractProduct()
        {
            Pages.Order.SubtractProduct();
        }
        
        [Then(@"the product is removed from the cart")]
        public void ThenTheProductIsRemovedFromTheCart()
        {
            Pages.Order.IsShoppingCartEmptyMessage();
        }
        
        [Then(@"The product should be added")]
        public void ThenTheProductShouldBeAdded()
        {
            Pages.Order.IsProductAdded();
        }
        
        [Then(@"The product should be subtracted")]
        public void ThenTheProductShouldBeSubtracted()
        {
            Pages.Order.IsProductSubtract();
        }
    }
}
