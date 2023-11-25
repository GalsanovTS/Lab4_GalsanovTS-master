using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://www.cyberforum.ru/csharp-beginners/thread2787061.html");

        var comments = driver.FindElements(By.CssSelector("#post15280941 > tbody"));
        Console.WriteLine(comments.Count);

        foreach (var comment in comments)
        {
            var username = comment.FindElement(By.CssSelector("#post15280941 > tbody > tr:nth-child(1) > td > div:nth-child(1) > a")).Text; 
            var commentText = comment.FindElement(By.CssSelector("#post_message_15280941")).Text;

            Console.WriteLine($"Username: {username} - Comment: {commentText}");
        }

        driver.Quit();
    }
}