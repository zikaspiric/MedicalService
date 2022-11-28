using MedicalService.Driver;
using MedicalService.Page;

namespace MedicalService
{
    public class Tests
    {
        LoginPage loginpage;
        MedicalPage medicalPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginpage = new LoginPage();
            medicalPage = new MedicalPage();
        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }


        [Test]
        public void TC01_MakeAppointment_ShouldAppointmentBeCompleted()
        {
            loginpage.AppMedic.Click();
            loginpage.Login("John Doe", "ThisIsNotAPassword");
            medicalPage.SelectOptions("Hongkong CURA Healthcare Center");
            medicalPage.ChekBox.Click();
            medicalPage.MedicId.Click();
            medicalPage.Date.SendKeys("25/12/2022");
            medicalPage.Comment.SendKeys("Zakazano");
            medicalPage.ButtonApp.Submit();

            Assert.That("Appointment Confirmation", Is.EqualTo(medicalPage.Confirm.Text));
            

        }
    }
}