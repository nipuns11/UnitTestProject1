using OpenQA.Selenium;

namespace UnitTestProject1
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var h1s = Driver.Instance.FindElements(By.ClassName("menu-link-text"));
                if (h1s.Count > 0)
                    return h1s[0].Text == "Followed Sites";
                return false;

            }
        }
    }
}