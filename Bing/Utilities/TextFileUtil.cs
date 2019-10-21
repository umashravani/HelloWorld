using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Bing.Utilities
{
    
    class TextFileUtil
    {
        private IWebDriver driver;
        
  
        
        /// <summary>
        /// Read contents of a text file
        /// </summary>
        /// <param name="readFilePath"></param>
        /// <returns></returns>
        public String ReadTextFile(string readFilePath)
        {
         
            string contenets = System.IO.File.ReadAllText(readFilePath);
            Console.WriteLine(contenets);
            return contenets;
            

        }
        /// <summary>
        /// Write contents into text file
        /// </summary>
        /// <param name="writeFilePath"></param>
        /// <param name="contents"></param>
        public void WriteToFile(string writeFilePath, string contents)
        {

            System.IO.File.WriteAllText(writeFilePath, contents);
            Console.WriteLine(contents);
            



        }
     
    }
}
