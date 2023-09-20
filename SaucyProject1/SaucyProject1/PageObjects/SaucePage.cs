using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V114.Network;
using SaucyProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reactive.Joins;
using System.Text;
using System.Threading.Tasks;

namespace SaucyProject1.PageObjects
{
    public class SaucePage
    {
        public IWebDriver driver;

        public SaucePage() 
        {
            driver = WebHooks.driver;
        }

        private string url = "https://www.saucedemo.com/";
        private By validUserNameField = By.CssSelector("#user-name");
        private By validPasswordField = By.CssSelector("#password");
        private By loginButton = By.XPath("//input[@id='login-button']");
        private IWebElement products => driver.FindElement(By.XPath("//span[@class='title']"));
        
        //Locked-Out User WebEelements
        private By lockedUserNameField = By.CssSelector("#user-name");
        private By lockedPasswordField = By.CssSelector("#password");
        private IWebElement errorMessage => driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]/h3"));

        //Login with Standard user
        public void NavigateToUrl()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterTextInUserName()
        {
            driver.FindElement(validUserNameField).SendKeys("standard_user");
        }

        public void EnterTextInPassword()
        {
            driver.FindElement(validPasswordField).SendKeys("secret_sauce");
        }
        public void ClickOnLogin()
        {
            driver.FindElement(loginButton).Click();
        }

        public bool IsSaucePageDisplayed()
        {
            return driver.Url == "https://www.saucedemo.com/";
            
        }
        public void AssertProductsDisplayed()
        {

            Assert.True(products.Displayed);
        }

        //Login with Locked-Out User

        public void EnterTextInLockedUserName()
        {
            driver.FindElement(lockedUserNameField).SendKeys("locked_out_user");
        }

        public void EnterTextInLockedPassword()
        {
            driver.FindElement(lockedPasswordField).SendKeys("secret_sauce");
        }

        public void AssertErrorMessageDisplayed()
        {
            Assert.True(errorMessage.Displayed);
        }
       
    }
}
