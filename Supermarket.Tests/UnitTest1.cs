using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Supermarket.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LogicalAndWorksProperly()
        {
            // logical and &&

            var a = true && true;
            var b = true && false;
            var c = false && true;
            var d = false && false;
            
            //bool a b c d || bob

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);
        }
    }
}
