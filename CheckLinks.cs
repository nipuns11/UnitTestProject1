using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1
{
 
 
        public class CheckLinks
        {


        [TestInitialize]
            public void init()
            {
                Driver.Initialize();
            }
            [TestMethod]
            public static void CheckBasicLinks()
            {
            var followed = Driver.Instance.FindElement(By.LinkText("Followed Sites"));
            
            Assert.AreEqual(followed.Text, "Followed Sites");

             }
            [TestMethod]
            public static void CheckConvo()
            {
            Driver.Instance.FindElement(By.LinkText("Conversations")).Click();
            var convo = Driver.Instance.FindElement(By.CssSelector(".empty-content__action")).Displayed;
            //Driver.Instance.Navigate().GoToUrl("https://wordpress.com/read/conversations");
            //WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));
            //wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("CssSelector") == ".empty-content__action");
            Assert.AreEqual(true,convo );
        }

            [TestCleanup]
            public void Cleanup()
            {
              Driver.Close();
            }
        }
    }


