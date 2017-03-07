using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Supermarket.Tests
{
    [Binding]
    public sealed class SpecialOffersSteps
    {
        public Basket testBasket;

        /// <summary>
        ///  something changed
        /// </summary>
        /// <param name="numberOfApples"></param>
        /// <param name="pricePerApple"></param>

        [Given(@"I buy (.*) apples at £(.*) each")]
        public void GivenIBuyApplesAtEach(int numberOfApples, decimal pricePerApple)
        {
            // create the basket
            testBasket = new Basket();

            // for loop has three parts
            // for (initialisation; test; increment) { code goes here }
            for (var i = 0; i < numberOfApples; i++)
            {
                testBasket.Items.Add(new BasketItem(pricePerApple) { ItemName = "Apple" });
            }
        }

        [Given(@"for every (.*) apples there is a discount of £(.*)")]
        public void GivenForEveryApplesThereIsADiscountOf(int multiple, decimal discount)
        {
            testBasket.AddDiscount(
                basket => basket.Items
                            .Where(item => item.ItemName == "Apple")
                            .Where((_, index) => (index + 1) % multiple == 0)
                        , item => item.Price - discount);
        }

        [When(@"I need to make payment")]
        public void WhenINeedToMakePayment()
        {
            // nothing to do here
        }

        [Then(@"the total is £(.*)")]
        public void ThenTheTotalIs(Decimal p0)
        {
            Assert.AreEqual(p0, testBasket.Total());
        }

    }
}
