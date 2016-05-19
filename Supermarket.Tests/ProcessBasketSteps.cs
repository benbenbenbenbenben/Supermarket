using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Supermarket.Tests
{
    [Binding]
    public sealed class ProcessBasketSteps
    {
        public Basket testBasket;
        public Bill testBill;

        [Given(@"I buy the following books")]
        public void GivenIBuyTheFollowingBooks(Table table)
        {
            testBasket = new Basket();

            List<BasketItem> books = table.CreateSet<BasketItem>().ToList();

            for (var i = 0; i < books.Count; i++)
            {
                books[i].ItemType = "Book";
            }

            testBasket.Items.AddRange(books);
        }

        [When(@"the basket is sent to the checkout")]
        public void WhenTheBasketIsSentToTheCheckout()
        {
            var Checkout = new Checkout();

            testBill = Checkout.ProcessBasket(testBasket);
        }

        [Then(@"the bill shows the following")]
        public void ThenTheBillShowsTheFollowing(Table table)
        {
            // assert the bill and table are same length
            Assert.AreEqual(table.RowCount, testBill.Lines.Count);

            for (int i = 0; i < table.RowCount; i++)
            {
                var expectedText = table.Rows[i]["Item Type"];
                if (expectedText == "<BLANK LINE>")
                    continue;
                var expectedPrice = Convert.ToDecimal(table.Rows[i]["Item Price"]);

                var actual = Regex.Match(testBill.Lines[i], @"^([\w\s\:]+)\s+([\d\.]+$)");
                Assert.IsTrue(actual.Success, "Could not find <Item Type> and <Item Price> in bill line: " + testBill.Lines[i]);
                Assert.IsTrue(actual.Groups.Count == 3, "Wrong format for bill line: " + testBill.Lines[i]);

                var actualText = actual.Groups[1].Value.Trim();
                var actualPrice = Convert.ToDecimal(actual.Groups[2].Value.Trim());

                Assert.AreEqual(expectedText, actualText);
                Assert.AreEqual(expectedPrice, actualPrice);
            }
        }

    }
}
