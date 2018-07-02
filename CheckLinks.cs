using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

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
            var followed =  Driver.Instance.FindElement(By.LinkText("Followed Sites")).Enabled;
            
            Assert.Equals(followed,"Followed Sites");




        }
            [TestCleanup]
            public void Cleanup()
            {
              //  Driver.Close();
            }
        }
    }


