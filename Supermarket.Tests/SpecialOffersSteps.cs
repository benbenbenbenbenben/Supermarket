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

        [Given(@"I buy (.*) apples at £(.*) pound each")]
        public void GivenIBuyApplesAtPoundEach(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
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
