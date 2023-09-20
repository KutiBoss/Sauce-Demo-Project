using SaucyProject1.Hooks;
using SaucyProject1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SaucyProject1.StepDefinitions
{
    [Binding]
    public class SauceItemsStepDefinitions
    {

        ItemsPage itemsPage = new ItemsPage();

        [Given(@"I navigate to demo website")]
        public void GivenINavigateToDemoWebsite()
        {
            itemsPage.NavigateToUrl();
            itemsPage.EnterTextInUserName();
            itemsPage.EnterTextInPassword();
            itemsPage.ClickOnLogin();
        }

        [Then(@"I should see (.*) items listed on the page")]
        public void ThenIShouldSeeItemsListedOnThePage(int p0)
        {
            itemsPage.GetItemCount();
        }

        //Sorting Items

        [Given(@"I navigate to demo order website")]
        public void GivenINavigateToDemoOrderWebsite()
        {
            itemsPage.NavigateToUrl();
            itemsPage.EnterTextInUserName();
            itemsPage.EnterTextInPassword();
            itemsPage.ClickOnLogin();
        }

        [Given(@"I click sorting dropdown tab")]
        public void GivenIClickSortingDropdownTab()
        {
            itemsPage.ClickOnSortingDropDown();
        }

        [Given(@"I click on low to high price tab")]
        public void GivenIClickOnLowToHighPriceTab()
        {
            itemsPage.ClickOnLowToHigh();
        }

        [Then(@"I should see sauce labs onesie displayed")]
        public void ThenIShouldSeeSauceLabsOnesieDisplayed()
        {
            itemsPage.IsInventoryDisplayed();
            itemsPage.AssertInventoryItemDisplayed();
        }

        [Then(@"the first item should have the lowest price")]
        public void ThenTheFirstItemShouldHaveTheLowestPrice()
        {
            
        }

        [Then(@"the last item should have the highest price")]
        public void ThenTheLastItemShouldHaveTheHighestPrice()
        {
            
        }

        

    }
}
