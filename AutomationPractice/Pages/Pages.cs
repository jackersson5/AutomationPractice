using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace AutomationPractice
{
    public class Pages
    {
        public static IWebDriver driver = new ChromeDriver();

        private static Page GetPage<Page>() where Page : new()
        {
            var page = new Page();
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static AuthenticationPage Authentication
        {
            get { return GetPage<AuthenticationPage>(); }
        }

        public static AccountPage Account
        {
            get { return GetPage<AccountPage>(); }
        }

        public static RegistrationPage Registration
        {
            get { return GetPage<RegistrationPage>(); }
        }

        public static ForgotPasswordPage ForgotPassword
        {
            get { return GetPage<ForgotPasswordPage>(); }
        }

        public static ContactPage Contact
        {
            get { return GetPage<ContactPage>(); }
        }

        public static Navigation Navigation
        {
            get { return GetPage<Navigation>(); }
        }

        public static SearchPage Search
        {
            get { return GetPage<SearchPage>(); }
        }

        public static CartPage Cart
        {
            get { return GetPage<CartPage>(); }
        }

         public static ProductPage Product
        {
            get { return GetPage<ProductPage>(); }
        }

        public static CatalogPage Catalog
        {
            get { return GetPage<CatalogPage>(); }
        }

        public static OrderPage Order
        {
            get { return GetPage<OrderPage>(); }
        }

    }
}

