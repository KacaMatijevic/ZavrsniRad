using OpenQA.Selenium;
using ZavrsniRad.Driver;

namespace ZavrsniRad.Pages
{
    public class CardPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement ZipCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement ButtonContinue => driver.FindElement(By.Id("continue"));
        public IWebElement Finish => driver.FindElement(By.Id("finish"));
        public IWebElement OrderFinished => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));
        public IWebElement ItemTotal => driver.FindElement(By.XPath("//div[@class=\"summary_subtotal_label\"]"));
       
    }
}
