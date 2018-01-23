using System;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class OrderBarPaymentSteps
    {
        [Given(@"I am on Payment window")]
        public void GivenIAmOnPaymentWindow()
        {
            Browser.ClearCache();
            Pages.Order.GotoPayment();
        }
        
        [When(@"I choose pay by bank wire")]
        public void WhenIChoosePayByBankWire()
        {
            Pages.Order.PayByBankWire();
        }
        
        [When(@"I confirm my order")]
        public void WhenIConfirmMyOrder()
        {
            Pages.Order.ConfirmOrder();
        }
        
        [When(@"I choose pay by check")]
        public void WhenIChoosePayByCheck()
        {
            Pages.Order.PayByCheck();
        }
        
        [Then(@"Payment by bank wire confirmation should appear")]
        public void ThenPaymentByBankWireConfirmationShouldAppear()
        {
            Pages.Order.IsBankWireConfirmationAppear();
        }
        
        [Then(@"Payment by check confirmation should appear")]
        public void ThenPaymentByCheckConfirmationShouldAppear()
        {
            Pages.Order.IsCheckConfirmationAppear();
        }
    }
}
