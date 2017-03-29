using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Supermarket.Tests
{
    [TestClass]
    public class Proofs
    {
        [TestMethod]
        public void BitwiseAnd()
        {
            // bitwise and &

            var a = true & true;
            var b = true & false;
            var c = false & true;
            var d = false & false;

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);
        }

        [TestMethod]
        public void LogicalAnd()
        {
            // logical and &&

            var a = true && true;
            var b = true && false;
            var c = false && true;
            var d = false && false;

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);
        }
    }
}
