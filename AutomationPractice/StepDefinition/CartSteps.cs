using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class CartSteps
    {
        [Given(@"I am on Product page")]
        public void GivenIAmOnProductPage()
        {
            Browser.ClearCache();
            Browser.OpenDressesPage();
            Pages.Catalog.ClickProduct();
            Pages.Product.IsAt();
        }

        [Given(@"The product is on the cart")]
        public void GivenTheProductIsOnTheCart()
        {
            Pages.Product.AddToCart();
            Pages.Cart.ContinueShopping();
        }

        [Given(@"I add product to cart")]
        public void GivenIAddProductToCart()
        {
            Pages.Product.AddToCart();
        }
        
        [Given(@"I press Continue shopping")]
        public void GivenIPressContinueShopping()
        {
            Pages.Cart.ContinueShopping();
        }
        
        [When(@"I add product to cart")]
        public void WhenIAddProductToCart()
        {
            Pages.Product.AddToCart();
        }
        
        [When(@"I remove product on the cart view")]
        public void WhenIRemoveProductOnTheCartView()
        {
            Browser.ClearCache();
            Pages.Cart.RemoveProductFromCart();
        }
        
        [When(@"I enter the cart")]
        public void WhenIEnterTheCart()
        {
            Pages.Navigation.GoToCart();
        }
        
        [When(@"I press Continue shopping")]
        public void WhenIPressContinueShopping()
        {
            Pages.Cart.ContinueShopping();
        }
        
        [When(@"I press Proceed to checkout")]
        public void WhenIPressProceedToCheckout()
        {
             Pages.Cart.ProceedToCheckout();
        }
        
        [Then(@"The Product is added to cart")]
        public void ThenTheProductIsAddedToCart()
        {
             Pages.Cart.IsProductAdded();
        }
        
        [Then(@"The product is removed from the cart")]
        public void ThenTheProductIsRemovedFromTheCart()
        {
            Pages.Cart.IsCartEmpty();
        }

        [Then(@"Information about empty cart appears")]
        public void ThenInformationAboutEmptyCartAppears()
        {
            Pages.Order.IsShoppingCartEmptyMessage();
        }
        
        [Then(@"I am redirected to Product page")]
        public void ThenIAmRedirectedToProductPage()
        {
            Pages.Product.IsAt();
        }
        
        [Then(@"I am redirected to shopping cart summary")]
        public void ThenIAmRedirectedToShoppingCartSummary()
        {
            Pages.Order.IsAtSummary();
        }
    }
}
