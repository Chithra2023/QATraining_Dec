using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using QATraining_Dec2022.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QATraining_Dec2022.Utilities;

namespace QATraining_Dec2022.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
            [SetUp]
            public void LoginSteps()
            {
                driver = new ChromeDriver();

                // Login page object initialization and definition
                LoginPage loginPageObj = new LoginPage();
                loginPageObj.LoginActions(driver);

                //Home page object initialization and definition
                 HomePage homePageObj = new HomePage();
                homePageObj.GoToTMPage(driver);
        }
            [Test]
            public void CreateTM_Tests()
            {
                //TM Page object initialization and definition
                TMPage tmPageObj = new TMPage();
                tmPageObj.CreateTM(driver);
            }
            [Test]
            public void EditTM_Tests()
            {
                TMPage tmPageObj = new TMPage();
                tmPageObj.EditTM(driver);
            }
            [Test]
            public void DeleteTM_Tests()
            {
                TMPage tmPageObj = new TMPage();
                tmPageObj.DeleteTM(driver);
            }

            [TearDown]
            public void CloseTestRun()
            {
                driver.Quit();
            }

           
    }
}
