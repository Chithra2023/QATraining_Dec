

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Media;
using System;
using System.Diagnostics;

// Open the browser
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
else
{
    Console.WriteLine("Login failed, Test Failed");
}

// Navigate to Time & Materials

IWebElement adminstrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminstrationDropdown.Click();

Thread.Sleep(500);
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();


//Click on Create New button
Thread.Sleep(1500);
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();
Thread.Sleep(500);

//Select "Time" in the Type Code drop down
IWebElement typeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
typeCodeDropDown.Click();
Thread.Sleep(500);

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();
Thread.Sleep(500);


// Enter Code in the Code text box
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("CN_Dec2022");


// Enter the Description in desciption text box
IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
descriptionTextBox.SendKeys("CN_Dec2022");


//Enter price in the Price Per Unit text box
IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
overlappingTag.Click();

IWebElement pricePerUnitTextBox = driver.FindElement(By.Id("Price"));
pricePerUnitTextBox.SendKeys("250");


//Click on Save
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);

// Check if new time record has been created
IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if(newCode.Text == "CN_Dec2022")
 {
    Console.WriteLine(" The Time record created suscessfully, Test Passed");
 }
else
 {
    Console.WriteLine("The Time record hasn't been created sucessfully, Test Failed");
 }