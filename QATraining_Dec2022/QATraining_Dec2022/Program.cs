

// Open the browser

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Media;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Launch Turnup Portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// Identify the username  text box and enter valid User Name

IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");

// Identify the password text box and enter valid password

IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");

// Click on Login button

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// Check if the user has logged in sucessfully

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")

{
    Console.WriteLine("Succesfully logged in, Test Passed");
}
{
    Console.WriteLine("Login failed, Test Failed");
}
