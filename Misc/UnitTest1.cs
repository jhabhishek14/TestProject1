

using AngleSharp.Html.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using WebDriverManager.DriverConfigs.Impl;


namespace Misc
{
    public class Tests
    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {



            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
           driver = new ChromeDriver();

            //string Url2 = "https://www.Google.com";

            driver.Navigate().GoToUrl("https://www.Google.com");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@title='Search']")));

            JavascriptExecutor jsExec = (JavascriptExecutor)driver;
            jsExec.executeScript("document.getElementById('field_to_clear').value=''");



        }

        [Test]
        public void Test1()
        {

            driver.FindElement(By.XPath("//input[@title='Search']")).SendKeys("facebook");

            driver.FindElement(By.XPath("//input[@title='Search']")).SendKeys(Keys.Enter);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);

            //driver.FindElement(By.XPath("//input[@value='Google Search']")).Click();

            driver.FindElement(By.XPath("//a/h3")).Click();
            TestContext.WriteLine("ABC");
           IWebElement Dropdown = driver.FindElement(By.Id("day"));
            SelectElement s = new SelectElement(Dropdown);
            s.SelectByText("14");

            String[] a = { "hi", "", "" };
            int[] b = { 1, 2, 3 };
            ArrayList AL = new ArrayList();
            foreach(IWebElement A in AL)
            {
                
            }

       
    }
}