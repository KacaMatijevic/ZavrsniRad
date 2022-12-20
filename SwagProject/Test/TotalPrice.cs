using ZavrsniRad.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad.Test
{
    public class TotalPrice
    {
        LoginPage loginPage;
        ProductPage productPage;
        CardPage cardPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cardPage = new CardPage();
        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_CheckTotalPrice_TheTotalPriceShouldBeChecked()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddFirst.Click();
            productPage.AddSecond.Click();
            productPage.AddThird.Click();
            productPage.CartLink.Click();
            cardPage.Checkout.Click();
            cardPage.FirstName.SendKeys("Katarina");
            cardPage.LastName.SendKeys("Matijevic");
            cardPage.ZipCode.SendKeys("11000");
            cardPage.ButtonContinue.Submit();
            Assert.That(cardPage.ItemTotal.Text, Is.EqualTo("Item total: $53.97"));
        }

     
    }
}
