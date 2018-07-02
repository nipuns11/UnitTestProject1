using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

         /// <summary>
         /// 
         /// </summary>
         static void GoToNewPost()
        {

            

            Driver.Instance.FindElement(By.ClassName("site-title"));

            //var newPostLink = Driver.Instance.FindElement(By.XPath("//a[@href='https://ideastechno.wordpress.com/2018/06/22/es/']"));
            //newPostLink.Click();
        }

    }

    public class CreatePostCommand
    {
        public string title;
        // private string body;

        public CreatePostCommand(string title)
        {
            this.title = title;
        }
        // public CreatePostCommand WithBody(string body)
        //{
        //  this.body = body;
        //return this;
        //}

        /// <summary>
        /// 
        /// </summary>
        public void Publish()
        {
           
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(4));
            // Test the autocomplete response - Explicit Wait
            IWebElement autocomplete = wait.Until(x => x.FindElement(By.CssSelector(".textarea-autosize.editor-title__input")));
            var title1 = Driver.Instance.FindElement(By.CssSelector(".textarea-autosize.editor-title__input"));
            Thread.Sleep(1000);
            title1.Click();
            title1.SendKeys(title);
            var body1 = Driver.Instance.FindElement(By.Id("mceu_1-open"));
            body1.Click();
            Thread.Sleep(1000);
            Driver.Instance.FindElement(By.Id("mceu_58-text")).Click();
            
            //Driver.Instance.SwitchTo().Frame(Driver.Instance.FindElement(By.Id("tinymce")));   
            //Driver.Instance.FindElement(By.CssSelector("tinymce-1_ifr")).SendKeys(body);
            
            Thread.Sleep(1000);
            Driver.Instance.FindElement(By.ClassName("editor-ground-control__publish-button")).Click();
            Thread.Sleep(1000);
            Driver.Instance.FindElement(By.CssSelector(".editor-confirmation-sidebar__action > button:nth-child(1)")).Click();




        }


    }
}