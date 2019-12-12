using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace StumpSanityTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.sportsadda.com/");

            driver.Manage().Window.Maximize();


            FunctionalLib.waitForElement(driver, "/html/body/div[1]/div/myapp/section[3]/div/div/div/div[1]/div/section[1]/div/div/div[1]/div/h2");

            FunctionalLib.MouseOver(driver, "/html/body/div[1]/div/myapp/section[3]/div/div/div/div[1]/div/section[1]/div/div/div[1]/div/h2");

            for (int i = 2; i <= 4; i++)
            {

                FunctionalLib.waitForElement(driver, "/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[" + i + "]/a/span");

                FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[" + i + "]/a/span", "xpath");

                Thread.Sleep(2000);

                FunctionalLib.waitForElement(driver,"/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[" + i + "]/a/span");
                string title = driver.FindElement(By.XPath("/html/body/div[1]/header/section[1]/div/div[2]/div[2]/nav/ul/li[" + i + "]/a/span")).Text;

                Console.WriteLine(title);
                if (title.Contains("Cricket"))

                {
                    for (int j = 2; j <= 7; j++)
                    {

                        FunctionalLib.waitForElement(driver, "/html/body/div[1]/header/section[2]/div/div[2]/nav/ul/li[" + j + "]/a");
                        FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[2]/div/div[2]/nav/ul/li[" + j + "]/a", "xpath");
                        Thread.Sleep(2000);
                        string title2 = driver.FindElement(By.XPath("/html/body/div[1]/header/section[2]/div/div[2]/nav/ul/li[" + j + "]/a")).Text;

                        Console.WriteLine(title2);
                    }

                }
                if (title.Contains("Football"))

                {
                    for (int k = 2; k <= 8; k++)
                    {
                        FunctionalLib.waitForElement(driver, "/html/body/div[1]/header/section[3]/div/div[2]/nav/ul/li[" + k + "]/a");

                        FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[3]/div/div[2]/nav/ul/li[" + k + "]/a", "xpath");


                        Thread.Sleep(2000);
                        string title3 = driver.FindElement(By.XPath("/html/body/div[1]/header/section[3]/div/div[2]/nav/ul/li[" + k + "]/a")).Text;
                        Console.WriteLine(title3);

                    }

                }

                if (title.Contains("Kabaddi"))

                {
                    for (int a = 2; a <= 8; a++)
                    {
                        FunctionalLib.waitForElement(driver, "/html/body/div[1]/header/section[4]/div/div[2]/nav/ul/li[" + a + "]/a");

                        FunctionalLib.clickAction(driver, "/html/body/div[1]/header/section[4]/div/div[2]/nav/ul/li[" + a + "]/a", "xpath");
                        Thread.Sleep(2000);
                        string title4 = driver.FindElement(By.XPath("/html/body/div[1]/header/section[4]/div/div[2]/nav/ul/li[" + a + "]/a")).Text;
                        Console.WriteLine(title4);

                    }

                }
            }
        }

    }
    
}
