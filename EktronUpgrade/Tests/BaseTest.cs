using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;



namespace EktronUpgradeSse.Tests
{
   public class BaseTest
    {
        public IWebDriver driver;
        static string browser = ConfigurationManager.AppSettings["browser"];

        internal static string[] _emails;
        internal string _password;


        [OneTimeSetUp]
        public void FixtureSetup()
        {
           
            _emails = new string[]
            {
                "@sse.com",
                "@sse.com"
        };

            _password = "";
        }

        [SetUp]
        public void Start()
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "IE":
                   
                     var ieOptions = new InternetExplorerOptions()
                    {
                        InitialBrowserUrl = "about:blank",
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                         IgnoreZoomLevel = true,
                         EnableNativeEvents = true,
                         EnsureCleanSession = true,
                         RequireWindowFocus = true
                    };
             
                    string driOldV = @"C:\Users\mhakimov\source\repos\EktronUpgrade\packages\IEDriverServer_Win32_2.52.1";
                    driver = new InternetExplorerDriver(driOldV, ieOptions);
                    break;
                case "Firefox":
                    FirefoxDriverService service = FirefoxDriverService.
                        CreateDefaultService(@"C:\Users\mhakimov\source\repos\EktronUpgrade\packages\Selenium.Firefox.WebDriver.0.19.0\driver");
                    service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    driver = new FirefoxDriver(service);
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           
        }


        [TearDown]
        public void Close()
        {

            driver.Quit();
        }

        protected void UiTest(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                var filePath = @"C:\Users\mhakimov\source\repos\EktronUpgrade\Screenshots\";
                string currTime = DateTime.Now.ToString(@"MMM-ddd-d-HH.mm");
                string fileName = System.IO.Path.Combine(filePath, "ERROR-" + currTime + ".png");

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                string screenshot = ss.AsBase64EncodedString;
                byte[] screenshotAsByteArray = ss.AsByteArray;
                ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);

               
                //var screenshot = driver.TakeScreenshot();

                //var abc = new ScreenshotImageFormat();

                //screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);

                // This would be a good place to log the exception message and
                // save together with the screenshot

                throw;
            }
        }
    }
}
