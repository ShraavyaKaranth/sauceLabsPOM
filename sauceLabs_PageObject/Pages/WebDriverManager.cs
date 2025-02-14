using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace sauceLabs_PageObject.Utils
{
    public static class WebDriverManager
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.DebuggerAddress = "127.0.0.1:9222"; // Attach to running Chrome instance
                driver = new ChromeDriver(chromeOptions);
            }
            return driver;
        }

        public static void QuitDriver()
        {
            driver?.Quit();
            driver = null;
        }
    }
}



//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Edge;
//using System;

//namespace SpecFlowSauceDemo.Drivers
//{
//    public class WebDriverManager
//    {
//        private static IWebDriver driver;

//        public static IWebDriver GetDriver()
//        {
//            if (driver == null)
//            {
//                driver = InitializeDriver();
//            }
//            return driver;
//        }

//        private static IWebDriver InitializeDriver()
//        {
//            string browser = "chrome"; // Change this as needed or fetch from config

//            switch (browser.ToLower())
//            {
//                case "firefox":
//                    return new FirefoxDriver();
//                case "edge":
//                    return new EdgeDriver();
//                default:
//                    return new ChromeDriver();
//            }
//        }

//        public static void QuitDriver()
//        {
//            if (driver != null)
//            {
//                driver.Quit();
//                driver = null;
//            }
//        }
//    }
//}




////using OpenQA.Selenium;
////using OpenQA.Selenium.Chrome;

////namespace sauceLabs_PageObject.Utils
////{
////    public static class WebDriverManager
////    {
////        private static IWebDriver driver;

////        public static IWebDriver GetDriver()
////        {
////            if (driver == null)
////            {
////                driver = new ChromeDriver();
////                driver.Manage().Window.Maximize();
////            }
////            return driver;
////        }

////        public static void QuitDriver()
////        {
////            if (driver != null)
////            {
////                driver.Quit();
////                driver = null;
////            }
////        }
////    }
////}
