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
            item.ItemType = ItemTypeEnum.AlcoholicDrink;
            testBasket.Items.Add(item);
        }

        [When(@"I scan the .*")]
        public void WhenIScanTheBottle()
        {
            Checkout checkOut = new Checkout();
            try
            {
                checkOut.CheckBasket(testBasket);
            }
            catch (Exception e)
            {
                ScenarioContext.Current.Add("redlight", true);
            }
        }

        [Then(@"the light above the check-out should flash")]
        public void ThenTheLightAboveTheCheck_OutShouldFlash()
        {
            Assert.IsTrue(
                ScenarioContext.Current.ContainsKey("redlight") 
                && (bool)ScenarioContext.Current["redlight"]
                );
        }

        [Given(@"I'm going to buy a bottle of milk")]
        public void GivenIMGoingToBuyABottleOfMilk()
        {
            testBasket = new Basket();
            var item = new BasketItem();
            item.ItemType = ItemTypeEnum.NonAlcoholicDrink;
            testBasket.Items.Add(item);
        }
        [Given(@"I'm going to buy a scratchcard")]
        public void GivenIMGoingToBuyAScratchcard()
        {
            testBasket = new Basket();
            var item = new BasketItem();
            item.ItemType = ItemTypeEnum.ScratchCard;
            testBasket.Items.Add(item);
        }

        [Then(@"the light above the check-out should not flash")]
        public void ThenTheLightAboveTheCheck_OutShouldNotFlash()
        {
            Assert.IsFalse(
                 ScenarioContext.Current.ContainsKey("redlight")
                 && (bool)ScenarioContext.Current["redlight"]
                 );
        }

    }
}
