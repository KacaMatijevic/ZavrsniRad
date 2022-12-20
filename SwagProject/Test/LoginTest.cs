using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad.Test
{
    public class LoginTest
    {

        LoginPage loginPage;
        private string User2 = "Epic sadface: Password is required";
        private string User3 = "Epic sadface: Username is required";
        private string User4 = "Epic sadface: Username and password do not match any user in this service";



        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();

        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_LoginUser1_ShouldLoginUser1()
        {
            loginPage.Login("standard_user", "secret_sauce");
            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(WebDrivers.Instance.Url));
        }

        [Test]
        public void TC02_LoginUser2_ShouldNotLoginUser2()
        {
            loginPage.Login("standard_user", "");
            Assert.That(User2, Is.EqualTo(loginPage.ErrorMessage.Text));

        }
        [Test]
        public void TC03_LoginUser3_ShouldNotLoginUser3()
        {
            loginPage.Login("", "");
            Assert.That(User3, Is.EqualTo(loginPage.ErrorMessage.Text));
        }

        [Test]
        public void TC04_LoginUser4_ShouldNotLoginUser4()
        {
            loginPage.Login("Kaca", "Kaca2201");
            Assert.That(User4, Is.EqualTo(loginPage.ErrorMessage.Text));
        }
        [Test]
        public void TC05_loginUser5_ShouldLoginUser5()
        {
            loginPage.Login("problem_user", "secret_sauce");
            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(WebDrivers.Instance.Url));
        }
    }
}
