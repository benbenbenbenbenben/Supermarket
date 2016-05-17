using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Supermarket.Tests
{
    [Binding]
    public sealed class SpecialOffersSteps
    {
        public Basket testBasket;

        [Given(@"I buy (.*) apples at £(.*) pound each")]
        public void GivenIBuyApplesAtPoundEach(int numberOfApples, decimal pricePerApple)
        {
            // create the basket
            testBasket = new Basket();

            // for loop has three parts
            // for (initialisation; test; increment) { code goes here }
            for (var i = 0; i < numberOfApples; i++)
            {
                testBasket.Items.Add(new BasketItem(pricePerApple));
            }
        }

        [When(@"I need to make payment")]
        public void WhenINeedToMakePayment()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the total is £(.*)")]
        public void ThenTheTotalIs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
