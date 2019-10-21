using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Bing.Utilities
{
    class JsonUtil
    {
        
        /// <summary>
        /// Read contents of JSON file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public String ReadJsonFile(string filePath)
        {
           
            string contenets = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(contenets);
            return contenets;
        }
    }
}
