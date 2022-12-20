using OpenQA.Selenium;
using ZavrsniRad.Driver;

namespace ZavrsniRad.Pages
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement ButtonLogin => driver.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => driver.FindElement(By.XPath("//div[@class=\"error-message-container error\"]//h3[@data-test=\"error\"]"));

        public void Login(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            ButtonLogin.Submit();
        }


    }
}
