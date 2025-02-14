using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using sauceLabs_PageObject.Utils;

namespace sauceLabs_PageObject.Hooks
{
    [Binding]
    public class Hooks
    {
        private static IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Initializing WebDriver...");
            if (driver != null)
            {
                driver = sauceLabs_PageObject.Utils.WebDriverManager.GetDriver();
            }
            _scenarioContext["WebDriver"] = driver;
        }

        [AfterScenario]
        public void TearDown()
        {
            // Do nothing to keep the browser open
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //TestContext.Progress.WriteLine("Initializing WebDriver...");
            //if (driver != null)
            //{
            //    driver = sauceLabs_PageObject.Utils.WebDriverManager.GetDriver();
            //}// Start the browser once
            //FeatureRunner.RunOrderedTests(); // Run only selected feature tests
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            TestContext.Progress.WriteLine("Closing WebDriver...");
            //sauceLabs_PageObject.Utils.WebDriverManager.QuitDriver();  // Close the browser after all tests
        }
    }
}


//[BeforeScenario(Order = 1)]
//public void ExecuteLogin()
//{
//    var loginSteps = new LoginStepDefinitions();
//    loginSteps.GivenUserIsOnLoginPage();
//    loginSteps.WhenUserEntersUsernameAndPassword();
//    loginSteps.ThenUserIsLoggedIn();


//}

//[BeforeScenario(Order = 2)]
//public void ExecuteViewItem()
//{
//    var viewItemSteps = new ViewItemStepDefinitions();
//    viewItemSteps.GivenUserIsLoggedIn();
//    viewItemSteps.WhenUserViewsAnItem();
//    viewItemSteps.ThenItemDataIsDisplayed();
//}

//[BeforeScenario(Order = 3)]
//public void ExecuteAddToCart()
//{
//    var addToCartSteps = new AddToCartStepDefinitions();
//    addToCartSteps.GivenUserIsViewingAnItem();
//    addToCartSteps.WhenUserAddsItemToCartAndClicksOnCartButton();
//    addToCartSteps.ThenCartWillBeOpened();
//}

//[BeforeScenario(Order = 4)]
//public void ExecuteCheckout1()
//{
//    var checkout1Steps = new CheckoutStepDefinitions();
//    checkout1Steps.GivenTheCartIsOpened();
//    checkout1Steps.WhenUserClicksOnCheckoutButton();
//    checkout1Steps.ThenCheckoutPageWillBeOpened();
//}

//[BeforeScenario(Order = 5)]
//public void ExecuteCheckout2()
//{
//    var checkout2Steps = new Checkout2StepDefinitions();
//    checkout2Steps.GivenUserIsInCheckOutPage();
//    checkout2Steps.WhenUserEntersFirstnameLastnameAndPostalcodeAndClicksOnContinueButton();
//    checkout2Steps.ThenUserIsNavigatedToCheckoutOverviewPage();
//}

//[BeforeScenario(Order = 6)]
//public void ExecuteCheckoutOverview()
//{
//    var checkoutOverviewSteps = new CheckoutOverviewStepDefinitions();
//    checkoutOverviewSteps.GivenUserIsInCheckoutOverviewPage();
//    checkoutOverviewSteps.WhenUserScrollsDownAndClicksOnFinish();
//    checkoutOverviewSteps.ThenConfirmationPageWillBeAppeared();
//}

//[BeforeScenario(Order = 7)]
//public void ExecuteConfirmation()
//{
//    var confirmationSteps = new ConfirmationPageStepDefinitions();
//    confirmationSteps.GivenUserIsInTheConfirmationPage();
//    confirmationSteps.WhenUserChecksForConfirmationTextAndComparesItWithActualText();
//    confirmationSteps.ThenIfItMatchesTheTestCasePasses_ElseItFails();
//}



//using System;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using TechTalk.SpecFlow;
//using sauceLabs_PageObject.Utils; // Ensure this is correctly referenced

//namespace sauceLabs_PageObject.Hooks
//{
//    [Binding]
//    public class Hooks
//    {
//        private readonly ScenarioContext _scenarioContext;
//        private static IWebDriver driver; // Store driver instance

//        public Hooks(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//        }

//        [BeforeTestRun]
//        public static void BeforeTestRun()
//        {
//            TestContext.Progress.WriteLine("Initializing WebDriver...");
//            driver = sauceLabs_PageObject.Utils.WebDriverManager.GetDriver();// Fix: Ensure WebDriverManager is properly referenced
//        }

//        [AfterTestRun]
//        public static void AfterTestRun()
//        {
//            TestContext.Progress.WriteLine("Closing WebDriver...");
//            sauceLabs_PageObject.Utils.WebDriverManager.QuitDriver(); // Fix: Ensure WebDriverManager is properly referenced
//        }

//        [BeforeScenario]
//        public void Setup()
//        {
//            _scenarioContext["WebDriver"] = driver; // Fix: Store driver in ScenarioContext correctly
//        }

//        [AfterScenario]
//        public void TearDown()
//        {
//            Console.WriteLine("After Scenario Execution");
//            // Do NOT quit driver here; it should persist across all test runs
//        }
//    }
//}
