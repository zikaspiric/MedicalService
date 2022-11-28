using MedicalService.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Page
{
    public class MedicalPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public void SelectOptions(string text)
            {
            SelectElement element = new SelectElement(driver.FindElement(By.Id("combo_facility")));
            element.SelectByText(text);
        }
        public IWebElement ChekBox => driver.FindElement(By.Id("chk_hospotal_readmission"));
        public IWebElement MedicId => driver.FindElement(By.Id("radio_program_medicaid"));
        public IWebElement Date => driver.FindElement(By.Id("txt_visit_date"));
        public IWebElement Comment => driver.FindElement(By.Id("txt_comment"));
        public IWebElement ButtonApp => driver.FindElement(By.Id("btn-book-appointment"));
        public IWebElement Confirm => driver.FindElement(By.CssSelector(".text-center h2"));
    }
}
