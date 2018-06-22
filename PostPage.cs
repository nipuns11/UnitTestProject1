using OpenQA.Selenium;

namespace UnitTestProject1
{
    public class PostPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.ClassName("entry-title"));
                if (title != null)
                    return title.Text;
                return "";

            }
        }
    }
}