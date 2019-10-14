using System;
using System.Diagnostics;
using Bing.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bing
{
    [TestClass]
     public class BingSearchTest: Differentclass
    {
        //public IWebDriver driver;
        [TestInitialize]
        public void TestFirst()
        {
            BingSearchTest call = new BingSearchTest();
            call.TestInit();
        }

    [TestMethod]
    public void TestMethod1()
    {
            string actualtitle = driver.Title;
            String expectedTitle = "";
        //  Assert(actualtitle== expectedTitle);
            if (actualtitle.Contains(expectedTitle))
            {
                Console.WriteLine("Title is matching with expected value");
            }
            else
            {
                Console.WriteLine("Title is not matching with expected value");
            }




        }
    [TestCleanup]
        public void TestClean()
        {
           
            driver.Quit();
        }
    }
}
