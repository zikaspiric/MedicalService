using MedicalService.Driver;
using MedicalService.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Tests
{
    public class LoginTest
    {
        LoginPage loginpage;
        string Message = "Login failed! Please ensure the username and password are valid.";

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginpage = new LoginPage();

        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_EnterInvalidUserName_ShouldNotBeLongONPage()
        {
            loginpage.AppMedic.Click();
            loginpage.Login("Zika", "ThisIsNotAPassword");
            Assert.That(Message, Is.EqualTo(loginpage.UserNotLogin.Text));
        }
        [Test]
        public void TC02_EnterInvalidPassword_ShouldBeNotLoginPage()
        {
            loginpage.AppMedic.Click();
            loginpage.Login("John Doe", "aaaaaaaaaaaaa");
            Assert.That(Message, Is.EqualTo(loginpage.UserNotLogin.Text));
        }
        [Test]
        public void TC03_EnterNoData_ShouldBeNotLoginPage()
        {
            loginpage.AppMedic.Click();
            loginpage.Login("", "");
            Assert.That(Message, Is.EqualTo(loginpage.UserNotLogin.Text));
        }
    }
}
