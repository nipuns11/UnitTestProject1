using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void init()
        {
            Driver.Initialize();
        }
        [TestMethod]
        public void TestMethod1()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("scopethesound").WithPassword("niplifeow").Login();
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login");

        }
        [TestMethod]
        public void CheckTags()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("scopethesound").WithPassword("niplifeow").Login();
            CheckLinks.CheckBasicLinks();
            CheckLinks.CheckConvo();
            CheckLinks.Discovery();
            CheckLinks.Search();
            CheckLinks.Likes();
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
