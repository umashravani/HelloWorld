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
    
    class SeleniumActions
    {
        //public By c1 = By.ClassName("b_searchboxSubmit");
        //public By c2 = By.LinkText("Images");
        //public By g1 = By.ClassName("iusc");
        //public By s1 = By.ClassName("b_searchbox");
        //string s2 = "computer";
        IWebDriver driver;
        public SeleniumActions(IWebDriver webDriver)
        {
         driver = webDriver;
        }

        private void GetText()
        {
            throw new NotImplementedException();
        }

        public void ClickSearchIcon(By bingSearchField)
        {
            driver.FindElement(bingSearchField).Click();

        }
        public void ClickLink(By imagesLink)
        {

            driver.FindElement(imagesLink).Click();
        }


        public String GetText(By suggestedImage)
        {
            var str = driver.FindElement(suggestedImage).Text;
            return str;
        }

        public void TypeText(By searchBox, String searchKeyword)
        {
            driver.FindElement(searchBox).SendKeys(searchKeyword);

        }
    }
}
