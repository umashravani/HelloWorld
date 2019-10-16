using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bing.Tests
{
   public class Differentclass
    {
        public IWebDriver driver;

        [TestInitialize]
        public void TestInit()
        {
            driver = new ChromeDriver(@"C:\Selenium");
            driver.Navigate().GoToUrl("https://www.bing.com/");
        }

        [TestCleanup]
        public void TestClean()
        {
           
            driver.Quit();
           
        }
        protected void xyz()
        {
            

        }

    }
}
