using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/Home/AutomationPracticeForm");
        driver.Manage().Window.Maximize();

        try
        {
            // Wait briefly to ensure page loads
            Thread.Sleep(2000);

            // First name
            driver.FindElement(By.Id("fname")).SendKeys("shivam");

            // Last name
            driver.FindElement(By.Id("lname")).SendKeys("rai");

            // Gender
            driver.FindElement(By.Id("male")).Click();

            // Date of Birth
            driver.FindElement(By.Id("dob")).SendKeys("1995-06-15");

            // Mobile Number
            driver.FindElement(By.Id("mobile")).SendKeys("9876543210");

            Console.WriteLine("Form inputs filled successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}



