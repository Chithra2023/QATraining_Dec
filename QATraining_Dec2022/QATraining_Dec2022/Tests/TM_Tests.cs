

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
            [Test, Order(1), Description("Check if a new TM record can be created with valid data")]
            public void CreateTM_Tests()
            {
                //TM Page object initialization and definition
                TMPage tmPageObj = new TMPage();
                tmPageObj.CreateTM(driver);
            }
            [Test, Order(2), Description("Check if an existing record can be edited with valid data")]
            public void EditTM_Tests()
            {
                TMPage tmPageObj = new TMPage();
                tmPageObj.EditTM(driver);
            }
            [Test, Order(3), Description("Check if an existing record can be deleted")]
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
