using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class LoginPage
    {
        public static void GoTo()
        {
          
       
            Driver.Instance.Navigate().GoToUrl("https://wordpress.com/log-in?redirect_to=https%3A%2F%2Fwordpress.com%2F");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(6));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "usernameOrEmail");

        }
        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }


        public class LoginCommand
        {
            private readonly string userName;
            private string password;
            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;

        }

        public void Login()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(4));
                // Test the autocomplete response - Explicit Wait
                IWebElement autocomplete = wait.Until(x => x.FindElement(By.Id("usernameOrEmail")));
                var loginInput = Driver.Instance.FindElement(By.Id("usernameOrEmail"));
                loginInput.SendKeys(userName);

                var ContinueButton = Driver.Instance.FindElement(By.CssSelector("button.is-primary"));
                ContinueButton.Click();

                var passwordInput = Driver.Instance.FindElement(By.Id("password"));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.CssSelector("button"));
                loginButton.Click();



            }

        }
    }

}