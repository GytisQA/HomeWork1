using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PaskaitosKartojimas1
{
    class HWAT1
    {
        [Test]
        public static void HWMinus5Plus3()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            chrome.Manage().Window.Maximize();
            IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
            string myText1 = "-5";
            inputField1.SendKeys(myText1);
            IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
            string myText2 = "3";
            string FinalAnswer = "-2";
            inputField2.SendKeys(myText2);
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            Thread.Sleep(2000);
            chrome.FindElement(By.Id("at-cv-lightbox-close")).Click();
            button.Click();
            IWebElement result = chrome.FindElement(By.CssSelector("#displayvalue"));
            Assert.AreEqual(FinalAnswer, result.Text, "Number is wrong");
            chrome.Quit();
        }
        [Test]
        public static void HW2Plus2()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            chrome.Manage().Window.Maximize();
            IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
            string myText1 = "2";
            inputField1.SendKeys(myText1);
            IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
            string myText2 = "2";
            inputField2.SendKeys(myText2);
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            Thread.Sleep(2000);
            chrome.FindElement(By.Id("at-cv-lightbox-close")).Click();
            button.Click();
            IWebElement result = chrome.FindElement(By.CssSelector("#displayvalue"));
            Assert.AreEqual(myText1, myText2, result.Text, "Number is wrong");
            //visada butinas
            chrome.Quit();
        }
    }
}
