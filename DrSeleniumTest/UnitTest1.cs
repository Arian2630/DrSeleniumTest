using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Runtime;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace DrSeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\Users\\Arian\\source\\repos\\DrSeleniumTest\\chromedriver";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
        }
        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }
        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver(DriverDirectory);
            string url = "C:\\Users\\Arian\\VSCode\\DrVue\\index.htm";
            _driver.Navigate().GoToUrl(url);
            //IWebElement selectElement = _driver.FindElement(By.Id("getAllButton"));
            //buttonElement.Click();
            //SelectElement operations = new SelectElement(selectElement);
            //operations.SelectByText("*");
            IWebElement buttonElement = _driver.FindElement(By.Id("getAllButton"));
            buttonElement.Click();
            Thread.Sleep(1000);

            IWebElement searchinputElement = _driver.FindElement(By.Id("searchByInput"));
            searchinputElement.SendKeys("2022");
            Thread.Sleep(1000);

            IWebElement searchbuttonElement = _driver.FindElement(By.Id("searchByButton"));
            searchbuttonElement.Click();
            Thread.Sleep(1000);

            //add

            IWebElement addInput1 = _driver.FindElement(By.Id("addtitle"));
            addInput1.SendKeys("Elden");
            Thread.Sleep(1000);

            IWebElement addInput2 = _driver.FindElement(By.Id("addartist"));
            addInput2.SendKeys("Haval");
            Thread.Sleep(1000);

            IWebElement addInput3 = _driver.FindElement(By.Id("addduration"));
            addInput3.SendKeys("3.20");
            Thread.Sleep(1000);

            IWebElement addInput4 = _driver.FindElement(By.Id("addpublicationyear"));
            addInput4.SendKeys("2021");
            Thread.Sleep(1000);

            IWebElement addbuttonElement = _driver.FindElement(By.Id("addbutton"));
            addbuttonElement.Click();
            Thread.Sleep(1000);

            //update
            IWebElement updateInput1 = _driver.FindElement(By.Id("update1"));
            updateInput1.SendKeys("14");
            Thread.Sleep(1000);

            IWebElement updateInput2 = _driver.FindElement(By.Id("update2"));
            updateInput2.SendKeys("Le Monde Ou Rien");
            Thread.Sleep(1000);

            IWebElement updateInput3 = _driver.FindElement(By.Id("update3"));
            updateInput3.SendKeys("PNL");
            Thread.Sleep(1000);

            IWebElement updateInput4 = _driver.FindElement(By.Id("update4"));
            updateInput4.SendKeys("3.10");
            Thread.Sleep(1000);

            IWebElement updateInput5 = _driver.FindElement(By.Id("update5"));
            updateInput5.SendKeys("2018");
            Thread.Sleep(1000);

            IWebElement updatebutton1 = _driver.FindElement(By.Id("updatebutton"));
            updatebutton1.Click();
            Thread.Sleep(1000);

            //delete
            IWebElement deleteinput1 = _driver.FindElement(By.Id("deleteinput"));
            deleteinput1.SendKeys("14");
            Thread.Sleep(1000);

            IWebElement deletebuttonElement = _driver.FindElement(By.Id("deletebutton"));
            deletebuttonElement.Click();
            Thread.Sleep(1000);
        }

    }
}