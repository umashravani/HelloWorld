using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bing.Tests
{
    class SeeniumActions : Differentclass
    {


        [TestMethod]
        public void BingVerifySearchResult()
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            var obj = new SeeniumActions();
            obj.Click();
            obj.TypeText();
            obj.Click1();
            obj.GetText( );
            
            

        }

        private void GetText()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            driver.FindElement(By.ClassName("b_searchboxSubmit")).Click();

        }
        public void Click1()
        {

            driver.FindElement(By.LinkText("Images")).Click();
        }


        public String GetText(string str)
        {
           str=  driver.FindElement(By.ClassName("iusc")).GetAttribute("href");
            return str;
        }

        public void TypeText()
        {
            driver.FindElement(By.ClassName("b_searchbox")).SendKeys("computer");

        }
    }
}
