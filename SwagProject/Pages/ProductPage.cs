using OpenQA.Selenium;

namespace ZavrsniRad.Pages
{
    public class ProductPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AddFirst => driver.FindElement(By.XPath("(//button[@class=\"btn btn_primary btn_small btn_inventory\"])[1]"));
        public IWebElement AddSecond => driver.FindElement(By.XPath("(//button[@class=\"btn btn_primary btn_small btn_inventory\"])[2]"));
        public IWebElement AddThird => driver.FindElement(By.XPath("(//button[@class=\"btn btn_primary btn_small btn_inventory\"])[3]"));
        public IWebElement CartBadge => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));
        public IWebElement CartLink => driver.FindElement(By.ClassName("shopping_cart_link"));
        public IWebElement SortLowToHigh => driver.FindElement(By.XPath("//select[@class=\"product_sort_container\"]/option[@value=\"lohi\"]"));
        public IWebElement MenuClick => driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement AboutClick => driver.FindElement(By.Id("about_sidebar_link"));
        public IWebElement ShoppingCardClick => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement RemoveProducts => driver.FindElement(By.XPath("(//button[@class=\"btn btn_secondary btn_small cart_button\"])"));
        public IWebElement ContinueShopping => driver.FindElement(By.Id("continue-shopping"));
    }
}
