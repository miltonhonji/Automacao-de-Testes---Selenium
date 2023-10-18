using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Application.Actions
{
    public class GetTitle
    {
        //1. Apontar um navegador
        string chromeDrivePath = "";
        
        //2. Criar as configurações iniciais desse navegador
        ChromeOptions options = new ChromeOptions();

        //3. Chamar uma nova instância do browser
        public void Navigate()
        {
            using(ChromeDriver driver = new ChromeDriver(
                chromeDrivePath, options))
            {
                string url = "https://www.google.com/";
                driver.Navigate().GoToUrl(url);

                 string pageTitle = driver.Title;
                 Console.WriteLine($"Título da página é { pageTitle }");

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadKey();

                driver.Quit();
            }
        }

    }
}

