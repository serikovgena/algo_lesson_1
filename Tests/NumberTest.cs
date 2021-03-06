using System.Collections.Generic;
using lesson_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class NumberTest
    {
        int[] testedPrimeNumbersArray = new int[] { 
            2, 3, 5, 7, 11, 13, 17, 
            19, 23, 29, 31, 37, 41, 
            43, 47, 53, 59, 61, 67, 
            71, 73, 79, 83, 89, 97 };

        [TestMethod]
        public void FindAllPrimeNumbersInFirstHundred() =>
            CollectionAssert.AreEqual(Number.GetAllPrimeNumbersInFirstHundred(), testedPrimeNumbersArray);

        [TestMethod]
        public void ZeroIsPrime() => Assert.IsFalse(Number.IsPrime(0));

        [TestMethod]
        public void NumberOneIsPrime() => Assert.IsFalse(Number.IsPrime(1));
    }
}
