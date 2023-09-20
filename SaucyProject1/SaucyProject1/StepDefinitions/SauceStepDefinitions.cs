using SaucyProject1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SaucyProject1.StepDefinitions
{
    [Binding]
    public class SauceStepDefinitions
    {
        SaucePage saucePage = new SaucePage();

//Login With Standard and Password

        [Given(@"I navigate to sauce demo website")]
        public void GivenINavigateToSauceDemoWebsite()
        {
            saucePage.NavigateToUrl();
        }

        [When(@"I enter valid username")]
        public void WhenIEnterValidUsername()
        {
            saucePage.EnterTextInUserName();
        }

        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
            saucePage.EnterTextInPassword();
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            saucePage.ClickOnLogin();
        }

        [Then(@"landing page should be displayed")]
        public void ThenLandingPageShouldBeDisplayed()
        {
           saucePage.IsSaucePageDisplayed();
            saucePage.AssertProductsDisplayed();
        }

        //Login with Locked-Out User and Password

        [Given(@"I navigate to sauce website")]
        public void GivenINavigateToSauceWebsite()
        {
            saucePage.NavigateToUrl();
        }

        [When(@"I enter lockedout username")]
        public void WhenIEnterLockedoutUsername()
        {
            saucePage.EnterTextInLockedUserName();
        }

        [When(@"I enter locked password")]
        public void WhenIEnterLockedPassword()
        {
            saucePage.EnterTextInLockedPassword();
        }

        [When(@"I click the log in button")]
        public void WhenIClickTheLogInButton()
        {
            saucePage.ClickOnLogin();
        }

        [Then(@"error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            saucePage.AssertErrorMessageDisplayed();
        }




    }
}
