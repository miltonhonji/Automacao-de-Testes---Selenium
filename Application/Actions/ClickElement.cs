using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Application.Actions
{
    public class ClickElement
    {
        string chromeDrivePath = "";
        ChromeOptions options = new ChromeOptions();
        
        public void Navigate()
        {
            using (ChromeDriver driver = new ChromeDriver(chromeDrivePath, 
            options))
            {
                string url = "https://www.google.com/";
                driver.Navigate().GoToUrl(url);

                IWebElement serachBox = driver.FindElement(By.Id("APjFqb"));
                serachBox.SendKeys("formula 1");

                System.Threading.Thread.Sleep(300);

                IWebElement buttonOK = driver.FindElement(By.Name("btnK"));
                buttonOK.Click();

                                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}