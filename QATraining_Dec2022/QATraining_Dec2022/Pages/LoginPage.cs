

namespace QATraining_Dec2022.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            // Open the browser and maximize
             driver.Manage().Window.Maximize();

            // Launch Turnup Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            try
            {
                // Identify the username  text box and enter valid User Name
                IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys("hari");
            }

            catch(Exception ex)
            {
                Assert.Fail("Turn up portal page did not launch", ex.Message);
            }

            // Identify the password text box and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            // Click on Login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
