using NUnit.Framework;
using OpenQA.Selenium;
using QATraining_Dec2022.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QATraining_Dec2022.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on 'Create New' button in TM page
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
            //Wait.WaitForElementExits(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);

            // Check if new time record has been created
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(newCode.Text == "CN_Dec2022", "Fail- Actual Code and Expected Code do not match");
            Assert.That(newDescription.Text == "CN_Dec2022", "Actual Description and Expected decription do not match");
            Assert.That(newPrice.Text == "$250.00", "Actual Price and Expected Price do not match");

            // another method of assertions
            //if (newCode.Text == "CN_Dec2022")
            //{
            //    Assert.Pass("Time record created sucesfully");
            //}
            //else
            //{
            //    Assert.Fail("Time record hasn't been created");
            //}

        }
        public void EditTM(IWebDriver driver)
        {

        }
        public void DeleteTM(IWebDriver driver)
        {

        }
    }
}
