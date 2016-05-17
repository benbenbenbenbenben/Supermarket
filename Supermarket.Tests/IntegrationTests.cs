using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Supermarket.Tests
{
    /// <summary>
    /// Summary description for IntegrationTests
    /// </summary>
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void ThereIsABasketClass()
        {
            // arrange
            var types = Assembly.ReflectionOnlyLoad("Supermarket").GetTypes();

            // act
            var found = types.Any(type => type.Name == "Basket");

            // assert
            Assert.IsTrue(found, "Could not find Basket class in namespace Supermarket");
        }

        [TestMethod]
        public void ThereIsABasketItemClass()
        {
            // arrange
            var types = Assembly.ReflectionOnlyLoad("Supermarket").GetTypes();

            // act
            var found = types.Any(type => type.Name == "BasketItem");

            // assert
            Assert.IsTrue(found, "Could not find BasketItem class in namespace Supermarket");
        }

        [TestMethod]
        public void ThereIsACheckoutClass()
        {
            // arrange
            var types = Assembly.ReflectionOnlyLoad("Supermarket").GetTypes();

            // act
            var found = types.Any(type => type.Name == "Checkout");

            // assert
            Assert.IsTrue(found, "Could not find Checkout class in namespace Supermarket");
        }
    }
}
