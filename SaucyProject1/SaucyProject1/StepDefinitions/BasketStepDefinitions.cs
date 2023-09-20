using SaucyProject1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SaucyProject1.StepDefinitions
{
    [Binding]
    public class BasketStepDefinitions
    {
        BasketPage orderPage = new BasketPage();

        [Given(@"I navigate to demo site")]
        public void GivenINavigateToDemoSite()
        {
            orderPage.NavigateToUrl();
            orderPage.EnterTextInUserName();
            orderPage.EnterTextInPassword();
            orderPage.ClickOnLogin();
        }

        [When(@"I add (.*) items to the basket")]
        public void WhenIAddItemsToTheBasket(int itemCount)
        {
            //orderPage.AddToCart(itemCount);
            //orderPage.AddBackPack();
        }

        [Then(@"I should see (.*) items in the basket")]
        public void ThenIShouldSeeItemsInTheBasket(int p0)
        {
            
        }

        [When(@"I remove (.*) item from the basket")]
        public void WhenIRemoveItemFromTheBasket(int p0)
        {
            
        }
    }
}
