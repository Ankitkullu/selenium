using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace seleniumOne
{
    internal class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if(elementtype== "Id")
               driver.FindElement(By.Id(element)).SendKeys(value);
            if(elementtype== "Name")
                 driver.FindElement(By.Name(element)).SendKeys(value);
        }
        // click a button, checkbox ,option etc...
        public static void Click(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }
        // selecting a drop down control
       
            public static void Drop(IWebDriver driver, string element, string value, string elementtype)
            {
               
            }
        }
    }

