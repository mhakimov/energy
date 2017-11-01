using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse
{
    class Methods
    {
        IWebDriver driver;
        public Methods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickAt(IWebElement element)
        {
            ScrollIntoView(element);
            ExplicitWait(element, 10000);
            element.Click();
        }


        public void TypeInText(IWebElement element, string value)
        {
            ExplicitWait(element, 5000);
            element.SendKeys(value);
        }


        public void MoveIntoElement(IWebElement element)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }

        public void ScrollIntoView(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }



        public void ExplicitWait(IWebElement element, int miliseconds)
        {
            new WebDriverWait(driver, TimeSpan.FromMilliseconds(miliseconds)).
                          Until(ExpectedConditions.ElementToBeClickable(element));
        }


        public static T SelectRandomElement<T>(IEnumerable<T> enumerable)
        {
            var index = new Random().Next(0, enumerable.Count());
            return enumerable.ToList()[index];
        }

        //public void TakeScreenshot()
        //{
        //    ITakesScreenshot dri = driver as ITakesScreenshot;
        //    Screenshot screenshot = dri.GetScreenshot();
        // //   screenshot.SaveAsFile(dri, "gf");
        //}

      
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class QualityCentreIdAttribute : Attribute
    {
      //  int _testId;

        public QualityCentreIdAttribute(int testId)
        {
           // this._testId = testId;
        }
    }


   
}
