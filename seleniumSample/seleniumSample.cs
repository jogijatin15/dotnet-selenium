using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace ClassLibrary1
{
    public class openChrome

    {
        [Test]
        public void testSeNew()
        {
            Console.WriteLine("Hello World!");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            //StringAssert.Contains("Google", driver.Title);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Sauce Labs");
            query.Submit();
            driver.Close();
            driver.Quit();
        }
    }
}
