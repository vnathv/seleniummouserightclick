using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumMouseRightClick
{
    class Program
    {
        static void Main(string[] args)
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://www.google.com");

            IWebElement element = chromeDriver.FindElementById("lst-ib");

            //Method 1
            Actions actionBuilder = new Actions(chromeDriver);
            actionBuilder.ContextClick(element).Build().Perform();

            //Method 2
            Actions action = new Actions(chromeDriver);
            action.ContextClick(element).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Build().Perform();

        }
    }
}
