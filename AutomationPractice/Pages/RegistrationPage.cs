using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace AutomationPractice
{
    public class RegistrationPage
    {
        /* YOUR PERSONAL INFORMATION */

        [FindsBy(How = How.Id, Using = "id_gender1")]
        public IWebElement radioBtnGenderMr;

        [FindsBy(How = How.Id, Using = "id_gender2")]
        public IWebElement radionBtnGenderMrs;

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement txtPersonalFirstName;

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement txtPersonalLastName;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail;

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword;
        
        [FindsBy(How = How.Id, Using = "uniform-days")]
        public IWebElement txtDay;

        [FindsBy(How = How.Id, Using = "uniform-months")]
        public IWebElement txtMonth;

        [FindsBy(How = How.Id, Using = "uniform-years")]
        public IWebElement txtYear;

        /*YOUR ADRESS*/

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement txtAdressFirstName;

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement txtAdressLastName;

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement txtCompany;

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement txtAdressAdress;

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement txtCity;

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement txtState;

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement txtPostCode;

        [FindsBy(How = How.Id, Using = "id_country")]
        public IWebElement txtCountry;

        [FindsBy(How = How.Id, Using = "other")]
        public IWebElement txtOther;

        [FindsBy(How = How.Id, Using = "phone")]
        public IWebElement txtPhone;

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement txtPhoneMobile;

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement txtAlias;

        [FindsBy(How = How.XPath, Using = "//*[@id='submitAddress']")]
        public IWebElement btnSave;

        
        [FindsBy(How = How.CssSelector, Using = "#center_column > div")]
        public IWebElement txtValidation;

        [FindsBy(How = How.XPath, Using = "//*[@id='submitAccount']/span")]
        public IWebElement btnSubmitAccount;


        public void ClickRegister()
        {
            Browser.WaitById(10, "submitAccount");
            btnSubmitAccount.Click();
        }

        public bool IsAt()
        {
            return Browser.GetActualSiteUrl.Contains("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation");
        }

        //--ToDo

        public void FillRequiredRegisterFields(string PersonalFirstName,string PersonalLastName,string Email,string Password,string AddressFirstName,string
                                               AdressLastName,string Adress,string City,string State,string PostCode,string Country,string PhoneMobile,string Alias)
        {
            Browser.WaitById(10, "submitAccount");
            
            txtPersonalFirstName.SendKeys(PersonalFirstName);
            txtPersonalLastName.SendKeys(PersonalLastName);
            txtEmail.SendKeys(Email);
            txtPassword.SendKeys(Password);
            txtAdressFirstName.SendKeys(AddressFirstName);
            txtAdressLastName.SendKeys(AdressLastName);
            txtAdressAdress.SendKeys(Adress);
            txtCity.SendKeys(City);
            txtState.SendKeys(State);
            txtPostCode.SendKeys(PostCode);
            txtCountry.SendKeys(Country);
            txtPhoneMobile.SendKeys(PhoneMobile);
            txtAlias.SendKeys(Alias);
        }

        public bool CheckValidation()
        {
            Browser.WaitByCssSelector(10, "#center_column > div");
            return txtValidation.Displayed;
        }

        public void Save()
        {
            btnSave.Click();
        }
    }
}
