using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Web.Mvc;
using CalculatorWebApp.Models;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace UITests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckAddition()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                string url = "https://localhost:7029";
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.Id("x")).SendKeys("173");
                driver.FindElement(By.Id("y")).SendKeys("428");
                SelectElement operationType = new SelectElement(driver.FindElement(By.Id("OperationType"))); // Select List of operation type

                // Select an option
                operationType.SelectByText("Addition"); // operationType.SelectByIndex(0); zero-based
                Assert.Equal("Addition", operationType.SelectedOption.Text);

                IWebElement submit = driver.FindElement(By.Id("submit"));
                submit.Click();
                
                string actual = driver.FindElement(By.Id("result")).GetAttribute("value");

                Assert.Equal("601", actual);
            }
        }

        [Fact]
        public void CheckSubtraction()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                string url = "https://localhost:7029";
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.Id("x")).SendKeys("133");
                driver.FindElement(By.Id("y")).SendKeys("82");
                SelectElement operationType = new SelectElement(driver.FindElement(By.Id("OperationType"))); // Select list of operation types

                // Select an option
                operationType.SelectByText("Subtraction"); // operationType.SelectByIndex(1); zero-based
                Assert.Equal("Subtraction", operationType.SelectedOption.Text);

                IWebElement submit = driver.FindElement(By.Id("submit"));
                submit.Click();

                string actual = driver.FindElement(By.Id("result")).GetAttribute("value");

                Assert.Equal("51", actual);
            }
        }

        [Fact]
        public void CheckMultiplication()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                string url = "https://localhost:7029";
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.Id("x")).SendKeys("25");
                driver.FindElement(By.Id("y")).SendKeys("5");
                SelectElement operationType = new SelectElement(driver.FindElement(By.Id("OperationType"))); // Select List of operation type

                // Select an option
                operationType.SelectByText("Multiplication"); // operationType.SelectByIndex(2); zero-based
                Assert.Equal("Multiplication", operationType.SelectedOption.Text);

                IWebElement submit = driver.FindElement(By.Id("submit"));
                submit.Click();

                string actual = driver.FindElement(By.Id("result")).GetAttribute("value");

                Assert.Equal("125", actual);
            }
        }

        [Fact]
        public void CheckDivision()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                string url = "https://localhost:7029";
                driver.Navigate().GoToUrl(url);
                driver.FindElement(By.Id("x")).SendKeys("513");
                driver.FindElement(By.Id("y")).SendKeys("3");
                SelectElement operationType = new SelectElement(driver.FindElement(By.Id("OperationType"))); // Select List of operation type

                // Select an option
                operationType.SelectByText("Division"); // operationType.SelectByIndex(2); zero-based
                Assert.Equal("Division", operationType.SelectedOption.Text);

                IWebElement submit = driver.FindElement(By.Id("submit"));
                submit.Click();

                string actual = driver.FindElement(By.Id("result")).GetAttribute("value");

                Assert.Equal("171", actual);
            }
        }
    } 
}