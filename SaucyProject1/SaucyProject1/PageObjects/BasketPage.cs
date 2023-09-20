using OpenQA.Selenium;
using SaucyProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SaucyProject1.PageObjects
{
    public class BasketPage
    {

        public IWebDriver driver;

        public BasketPage()
        {
            driver = WebHooks.driver;
        }

        private string demoUrl = "https://www.saucedemo.com/";
        private By validUserNameField = By.CssSelector("#user-name");
        private By validPasswordField = By.CssSelector("#password");
        private By loginButton = By.XPath("//input[@id='login-button']");
        private By shoppingCart = By.XPath("//*[@id=\"shopping_cart_container\"]/a");
        private IWebElement addBackPack => driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack"));
        private IWebElement addBikeLight => driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-bike-light"));                                                                                          
        private IWebElement itemCount => driver.FindElement(By.CssSelector(" //*[@id=\"shopping_cart_container\"]/a/span"));

        private By addToCartButton = By.CssSelector("#add-to-cart-sauce-labs-backpack");
        public void NavigateToUrl()
        {
            driver.Navigate().GoToUrl(demoUrl);
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

        //public void AddBackPack()
        //{
        //    driver.FindElement((By)addBackPack).Click();
        //}

        //public void AddToCart(int itemCount)
        //{
        //    for (int i = 0; i < itemCount; i++)
        //    {
                
        //        //driver.FindElement(addToCartButton).Click();
        //        // ClickAddToCartButton();
        //    }
        //}

    }
}
