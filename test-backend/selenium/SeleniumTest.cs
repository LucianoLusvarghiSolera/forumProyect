using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_backend.selenium
{
    [TestClass]
    internal class SeleniumTest
    {

        [TestMethod]
        public void homePageTest()
        {
            WebDriver driver = new ChromeDriver();

            driver.Url = "http://localhost:3000";

            IWebElement element = driver.FindElement(By.Name("Hello"));
            element.Click();


        }

    }
}
