using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Supermarket.Tests
{
    [Binding]
    public class ProcessBasketWithBoozeSteps
    {
        public Basket testBasket;

        [Given(@"I'm going to buy a bottle of Chateau Neuf du Pape")]
        public void GivenIMGoingToBuyABottleOfChateauNeufDuPape()
        {
            // create the basket
            testBasket = new Basket();
            var item = new BasketItem();
            item.ItemType = "Booze";

            //var otherItem = new BasketItem
            //{
            //    ItemType = "Booze"
            //};

            testBasket.Items.Add(item);
        }

        private bool redLight = false;
        [When(@"I scan the bottle")]
        public void WhenIScanTheBottle()
        {
            Checkout checkOut = new Checkout();
            try
            {
                checkOut.CheckBasket(testBasket);
                redLight = false;
            }
            catch (Exception e)
            {
                redLight = true;
            }
        }

        [Then(@"the light above the check-out should flash")]
        public void ThenTheLightAboveTheCheck_OutShouldFlash()
        {
            Assert.IsTrue(redLight);
        }

        [Given(@"I'm going to buy a bottle of milk")]
        public void GivenIMGoingToBuyABottleOfMilk()
        {
            testBasket = new Basket();
            var item = new BasketItem();
            item.ItemType = "Milk";
            testBasket.Items.Add(item);
        }

        [Then(@"the light above the check-out should not flash")]
        public void ThenTheLightAboveTheCheck_OutShouldNotFlash()
        {
            Assert.IsFalse(redLight);
        }

    }
}
