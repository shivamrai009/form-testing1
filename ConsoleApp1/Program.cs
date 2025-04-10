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
            
            Thread.Sleep(2000);

            
            driver.FindElement(By.Id("fname")).SendKeys("shivam");

            
            driver.FindElement(By.Id("lname")).SendKeys("rai");

            
            driver.FindElement(By.Id("male")).Click();

            
            driver.FindElement(By.Id("dob")).SendKeys("1995-06-15");

            
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



