namespace ZavrsniRad.Test
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }


        [Test]
        public void TC01_SortProductByPrice_ShouldSortLowToHigh()
        {
            //Act
            loginPage.Login("standard_user", "secret_sauce");

            //Arrange
            productPage.SortLowToHigh.Click();

            //Assert
            Assert.That(productPage.SortLowToHigh.Displayed);
        }

        [Test]
        public void TC02_AddThreeProductsInCart_ShouldDisplayedThreeProducts()
        {
            loginPage.Login("standard_user", "secret_sauce");

            //sort low to high
            productPage.SortLowToHigh.Click();

            //add first three products --cheapest because they are sorted
            productPage.AddFirst.Click();
            productPage.AddSecond.Click();
            productPage.AddThird.Click();

            //assert that i have 3 products in cart
            Assert.That("3", Is.EqualTo(productPage.CartBadge.Text));
        }
        [Test]
        public void TC03_AddTwoProductInChart_ShouldRemoveTwoProductFromChart()
        {
            loginPage.Login("standard_user", "secret_sauce");
            //add products
            productPage.AddFirst.Click();
            productPage.AddSecond.Click();
            //go to cart
            productPage.CartBadge.Click();
            //remove products
            productPage.RemoveProducts.Click();
            productPage.RemoveProducts.Click();
            //back to shopping cart
            productPage.ContinueShopping.Click();
            //assert that cart is empty
            Assert.That(productPage.CartLink.Text, Is.EqualTo(""));

        }
        
    }
}