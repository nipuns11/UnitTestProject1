using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace UnitTestProject1
{
    public class Driver
    {
         public static IWebDriver Instance
        {
            get; set;
        }
        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        internal static void Close()
        {
           // Instance.Close();

        }
    }
}