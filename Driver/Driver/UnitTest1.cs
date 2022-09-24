using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace Driver
{
    public class Tests
    {
        public IWebDriver driver;
        IWebElement searchBox, videoLink;

        [SetUp]
        public void Setup()
        {
            // Setup
        }

        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com");
           
            searchBox = driver.FindElement(By.Name("search_query"));
            searchBox.SendKeys("not on the sidelines street fighter 6");
            searchBox.Submit();

            videoLink = driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer[1]/div[3]/ytd-video-renderer[1]/div[1]/ytd-thumbnail/a"));
            videoLink.Click();
            driver.FindElement(By.XPath("//button[@aria-label=\'Play\']")).Click();
        }
    }
}