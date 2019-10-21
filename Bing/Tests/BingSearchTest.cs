using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Bing.Tests;
using Bing.Utilities;
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

        public string readfile = @"C:\Users.txt";
       public string writefile = @"D:\Account.txt";
        public string text = "A class is the most powerful data type in C#. Like a structure, " +
                      "a class defines the data and behavior of the data type. ";
        public string readjsonfile= @"D:\person.json";



        [TestMethod]
        public void FileReadTest()
        {
            var temp = new TextFileUtil();
            temp.ReadTextFile(readfile);
 
         
        }
        [TestMethod]
        public void FileWriteTest()
        {
            var temp = new TextFileUtil();
            temp.WriteToFile(writefile,text);


        }
        [TestMethod]
        public void JsonReadTest()
        {
            var temp = new JsonUtil();
            temp.ReadJsonFile(readjsonfile);
          


        }

        [TestMethod]
        public void BingVerifySearchResult()
        {
            driver.Manage().Window.Maximize();
            var obj = new SeleniumActions(driver);
            obj.TypeText(BingSearchBox, BingSearchKeyword);
            obj.ClickSearchIcon(BingSearchField);
             obj.ClickLink(ImagesLink);
            var text = obj.GetText(SuggestedImage);
            Console.WriteLine(text);




        }

    }
   
}
