using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1
{
 
 
        public class CheckLinks
        {
//private static ITakesScreenshot driver;


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
            Assert.AreEqual(true,convo );
        }

        [TestMethod]
        public static void Discovery()
        {
            Driver.Instance.FindElement(By.LinkText("Discover")).Click();
            var disco = Driver.Instance.FindElement(By.LinkText("Discover")).Displayed;
            Assert.AreEqual(true, disco);
        }


        [TestMethod]
        public static void Search()
        {
            Driver.Instance.FindElement(By.LinkText("Search")).Click();
            //((ITakesScreenshot)FirefoxInstance).GetScreenshot().SaveAsFile("", System.Drawing.Imaging.ImageFormat.Jpeg);
            var search = Driver.Instance.FindElement(By.LinkText("Search")).Displayed;
            Assert.AreEqual(true, search);

        }

        [TestMethod]
        public static void Likes()
        {
            Driver.Instance.FindElement(By.PartialLinkText("Likes")).Click();
            //((ITakesScreenshot)FirefoxInstance).GetScreenshot().SaveAsFile("", System.Drawing.Imaging.ImageFormat.Jpeg);
            var  likes = Driver.Instance.FindElement(By.PartialLinkText("Likes")).Displayed;
            Assert.AreEqual(true, likes);

        }

        
        }
    }


