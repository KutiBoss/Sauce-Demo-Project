using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SaucyProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucyProject1.PageObjects
{
    public class ItemsPage
    {
        public IWebDriver driver;

        public ItemsPage()
        {
            driver = WebHooks.driver;
        }

        private string url = " https://www.saucedemo.com/";
        private string demoUrl = "https://www.saucedemo.com/inventory.html";
        private By validUserNameField = By.CssSelector("#user-name");
        private By validPasswordField = By.CssSelector("#password");
        private By loginButton = By.XPath("//input[@id='login-button']");
        //private By itemCount = By.ClassName("#inventory_container > div");
        //private int IWebElement itemCount => driver.FindElement(By.XPath("#inventory_container > div"));

        private By sortingDropDownTab = By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select");
        private By lowToHighPriceTab = By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[3]");

        private IWebElement inventoryItem => driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select/option[4]"));
        private IWebElement priceDropDown => driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[2]/div/span/select"));
        private IWebElement firstItemPrice => driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[1]/div[2]/div[2]/div"));
        private IWebElement secondItemPrice => driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[6]/div[2]/div[2]/div"));
       
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

        public int GetItemCount() =>
            
            driver.FindElements(By.CssSelector("#inventory_container > div")).Count;

        //Sorting Items

        public void ClickOnSortingDropDown()
        {
            driver.FindElement(sortingDropDownTab).Click();

        }

        public void ClickOnLowToHigh()
        {
            //SelectElement select = new SelectElement((IWebElement)lowToHighPriceTab);
            //select.SelectByText("Price (low to high)");
            driver.FindElement(lowToHighPriceTab).Click();

        }

        public bool IsInventoryDisplayed()
        {
            return driver.Url == demoUrl;
        }

        public void AssertInventoryItemDisplayed() 
        {
            Assert.True(inventoryItem.Displayed);
        }

        //public bool IsFirstItemPriceLowest()
        //{
            
        //    decimal firstItemPrice = GetItemPrice(1);
        //    decimal secondItemPrice = GetItemPrice(6);
        //    return firstItemPrice < secondItemPrice;
        //}

        //public bool IsLastItemPriceHighest()
        //{
        //    int itemCount = GetItemCount();
           
        //    decimal lastItemPrice = GetItemPrice(itemCount);
        //    decimal secondToLastItemPrice = GetItemPrice(itemCount - 1);
        //    return lastItemPrice > secondToLastItemPrice;
        //}

        //public decimal GetItemPrice(int v)
        //{
        //    //return decimal.TryParse(priceText.ToString("$\", \"\""));                          
        //}

       
    }
}
