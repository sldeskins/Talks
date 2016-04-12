using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveRoutines;

namespace RecursiveRoutinesTest
{
    [TestClass]
    public class FibonacciExampleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The value must be an integer greater than or equal to zero.")]
        public void InvalidRange()
        {
            int result = FibonacciExample.Fib(-987);
        }
        [TestMethod]
        public void N0()
        {
            int result = FibonacciExample.Fib(0);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void N1()
        {
            int result = FibonacciExample.Fib(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void N6()
        {
            int result = FibonacciExample.Fib(6);
            Assert.AreEqual(8, result);
        }
    }
}
