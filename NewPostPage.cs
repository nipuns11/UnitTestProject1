using OpenQA.Selenium;
using System;
using System.Threading;

namespace UnitTestProject1
{
    public class NewPostPage
    {
        public static void Goto()
        {
            //var menuPosts = Driver.Instance.FindElement(By.ClassName("masterbar__item-content"));
            //menuPosts.Click();
            var addNew = Driver.Instance.FindElement(By.LinkText("Write"));
            addNew.Click();

        }

        public static CreatePostCommand CreatePost(string title)

        {
            return new CreatePostCommand(title);

        }

        public static void GoToNewPost()
        {
            var message = Driver.Instance.FindElement(By.ClassName("notice__text"));
            var newPostLink = Driver.Instance.FindElement(By.XPath("//a[@href='https://ideastechno.wordpress.com/2018/06/22/es/']"));
            newPostLink.Click();
        }

    }

    public class CreatePostCommand
    {
        private string title;
        private string body;

        public CreatePostCommand(string title)
        {
            this.title = title;
        }
    public CreatePostCommand WithBody(string body)
        {
         this.body = body;
            return this;
        }

        public void Publish()
        {
            Driver.Instance.FindElement(By.CssSelector("textarea-autosize editor-title__input")).SendKeys(title);
            Driver.Instance.FindElement(By.CssSelector(".mce-content-body p")).SendKeys(body);
            Thread.Sleep(1000);
            Driver.Instance.FindElement(By.ClassName("editor-ground-control__publish-button")).Click();
            Driver.Instance.FindElement(By.ClassName("editor-confirmation-sidebar__actionbutton")).Click();


        }


    }
}