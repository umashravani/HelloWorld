using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Bing.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bing
{
    [TestClass]
     public class BingSearchTest: Differentclass
    {

        public By BingSearchField= By.ClassName("b_searchboxSubmit");
        public By ImagesLink = By.LinkText("Images");
        public By SuggestedImage = By.ClassName("suggestion-title");
        public By BingSearchBox = By.ClassName("b_searchbox");
        string BingSearchKeyword = "computer";

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

        [TestMethod]
        public void BingVerifySearchResult()
        {
            driver.Manage().Window.Maximize();
            //Thread.Sleep(10000);
            var obj = new SeleniumActions(driver);
            obj.TypeText(BingSearchBox, BingSearchKeyword);
            obj.ClickSearchIcon(BingSearchField);
             obj.ClickLink(ImagesLink);
            var text = obj.GetText(SuggestedImage);
            Console.WriteLine(text);




        }

    }
   
}
