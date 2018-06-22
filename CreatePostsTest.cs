using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class CreatePostsTest
    {
        [TestInitialize]
        public void init()
        {
            Driver.Initialize();
        }
        [TestMethod]
        public void CanCreateBasicPost()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("scopethesound").WithPassword("niplifeow").Login();

            NewPostPage.Goto();
            NewPostPage.CreatePost("This is a Test post title").WithBody("Hi,this is the body").Publish();
            NewPostPage.GoToNewPost();
            Assert.AreEqual(PostPage.Title, "This is a Test post title","The title post did not match");
               

        }
        [TestCleanup]
        public void Cleanup()
        {
            //Driver.Close();
        }
    }
}
