using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationPractice
{

    public class OrderPage
    {
        //--Summary

        [FindsBy(How = How.XPath, Using = "//*[@id='3_13_0_0']")]
        public IWebElement btnRemove;

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_quantity_up_3_13_0_0']/span")]
        public IWebElement btnAddProduct;

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_quantity_down_3_13_0_0']")]
        public IWebElement btnSubtractProduct;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p")]
        public IWebElement msgEmpty;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[3]/div/div/div[3]/div/a/span[1]")]
        public IWebElement txtNumberOfProduct;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[2]/a[1]")]
        public IWebElement btnSummaryProceedToCheckout;

        /*SignIn*/


        //--Address

        [FindsBy(How = How.XPath, Using = "//*[@id='address_delivery']/li[7]/a")]
        public IWebElement btnUpdateDelivery;

        [FindsBy(How = How.XPath, Using = "//*[@id='address_invoice']/li[7]/a")]
        public IWebElement btnUpdateBilling;

        [FindsBy(How = How.XPath, Using = "//*[@id='address_delivery']/li[4]")]
        public IWebElement txtCity;

        [FindsBy(How = How.XPath, Using = "//*[@id='address_invoice']/li[3]")]
        public IWebElement txtAddress;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/form/p/button")]
        public IWebElement btnAddressProceedToCheckout;

        //--Shipping

        [FindsBy(How = How.XPath, Using = "//*[@id='cgv']")]
        public IWebElement checkbox;

        [FindsBy(How = How.XPath, Using = "//*[@id='form']/p/button")]
        public IWebElement btnShippingProceedToCheckout;


        //--Payment

        [FindsBy(How = How.XPath, Using = " //*[@id='HOOK_PAYMENT']/div[1]/div/p/a")]
        public IWebElement btnPayByBankWire;

        [FindsBy(How = How.XPath, Using = "//*[@id='HOOK_PAYMENT']/div[2]/div/p/a")]
        public IWebElement btnPayByCheck;

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_navigation']/button")]
        public IWebElement btnConfirmOrder;

        [FindsBy(How = How.XPath, Using = " //*[@id='center_column']/div/p/strong")]
        public IWebElement msgBankWireConfirmation;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[1]")]
        public IWebElement msgCheckConfirmation;


        //--Summary

        public void GoToSummaryScreenWithAProductInCart()
        {
            Browser.OpenDressesPage();
            Pages.Catalog.ClickProduct();
            Pages.Product.AddToCart();
            Pages.Cart.ProceedToCheckout();
        }

        public void SummaryProceedToCheckout()
        {
            btnSummaryProceedToCheckout.Click();
        }

        public void IsAtSummary()
        {
            Browser.GetActualSiteUrl.Contains("http://automationpractice.com/index.php?controller=order");
        }

        public void IsShoppingCartEmptyMessage()
        {
            Browser.WaitByXpath(10,"//*[@id='center_column']/p");
            Assert.True(msgEmpty.Text.Equals("Your shopping cart is empty."));
        }

        public void RemoveProduct()
        {
            btnRemove.Click();
        }

        public void getNumberOfProduct()
        {
            txtNumberOfProduct.GetCssValue("value");
        }

        public void AddProduct()
        {
            Browser.WaitByXpath(10, "//*[@id='cart_quantity_up_3_13_0_0']/span");
            btnAddProduct.Click();
        }

        public void SubtractProduct()
        {
            btnSubtractProduct.Click();
        }

        public void IsProductAdded()
        {
            Browser.WaitByXpath(10, "//*[@id='header']/div[3]/div/div/div[3]/div/a/span[1]");
            Assert.True(txtNumberOfProduct.Text.Contains(""));
        }

        public void IsProductSubtract()
        {
            Browser.WaitByXpath(10, "//*[@id='center_column']/p");
            Assert.True(msgEmpty.Text.Equals("Your shopping cart is empty."));
        }

        //--SignIn

        public void GoToSignInWindowNotLoggedIn()
        {
            Browser.OpenDressesPage();
            Pages.Catalog.ClickProduct();
            Pages.Product.AddToCart();
            Pages.Cart.ProceedToCheckout();
            Pages.Order.SummaryProceedToCheckout();
        }

        //--Address

        public void GotoAddress()
        {
            GoToSignInWindowNotLoggedIn();
            Pages.Authentication.SignIn("darengibson@automationpractice.com", "11111");
        }

        public void UpdateDeliveryAddress()
        {
            btnUpdateDelivery.Click();
        }

        public void UpdateBillingAddress()
        {
            btnUpdateBilling.Click();
        }

        public void IsAtAddress()
        {
            Browser.GetActualSiteUrl.Contains("http://automationpractice.com/index.php?controller=order&step=1&multi-shipping=0");
        }

        public void AddressProceedToCheckout()
        {
            btnAddressProceedToCheckout.Click();
        }

        //--Shipping

        public void ShippingProceedToCheckout()
        {
            btnShippingProceedToCheckout.Click();
        }

        public void SetCheckboxChecked()
        {
            checkbox.Click();
        }

        //--Payment

        public void GotoPayment()
        {
            GotoAddress();
            AddressProceedToCheckout();
            SetCheckboxChecked();
            ShippingProceedToCheckout();
        }

        public void PayByBankWire()
        {
            Browser.WaitByXpath(10, "//*[@id='HOOK_PAYMENT']/div[1]/div/p/a");
            btnPayByBankWire.Click();
        }

        public void PayByCheck()
        {
            btnPayByCheck.Click();
        }

        public void ConfirmOrder()
        {
            btnConfirmOrder.Click();
        }

        public void IsBankWireConfirmationAppear()
        {
            Assert.True(msgBankWireConfirmation.Text.Equals("Your order on My Store is complete."));
        }

        public void IsCheckConfirmationAppear()
        {
            Browser.WaitByXpath(10, "//*[@id='center_column']/p[1]");
            Assert.True(msgCheckConfirmation.Text.Equals("Your order on My Store is complete."));
        }

    }
}
