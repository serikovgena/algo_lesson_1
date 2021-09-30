using System.Collections.Generic;
using lesson_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class NumberTest
    {
<<<<<<< HEAD
        int[] testedPrimeNumbersArray = new int[] { 
=======
        int[] primeNumbersInHundred = new int[] { 
>>>>>>> e893b89685b7c0ef4d0de32293d9c7e5d1ca15c1
            2, 3, 5, 7, 11, 13, 17, 
            19, 23, 29, 31, 37, 41, 
            43, 47, 53, 59, 61, 67, 
            71, 73, 79, 83, 89, 97 };

        [TestMethod]
<<<<<<< HEAD
        public void FindAllPrimeNumbersInFirstHundred() =>
            CollectionAssert.AreEqual(Number.GetAllPrimeNumbersInFirstHundred(), testedPrimeNumbersArray);
=======
        public void FindAllPrimeNumbersInFirstHundred()
        {
            var primeNumbersList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (Number.IsPrime(i)) primeNumbersList.Add(i);
            }
            var primeNumbersArray = primeNumbersList.ToArray();

            CollectionAssert.AreEqual(primeNumbersArray, primeNumbersInHundred);
        }
>>>>>>> e893b89685b7c0ef4d0de32293d9c7e5d1ca15c1

        [TestMethod]
        public void ZeroIsPrime() => Assert.IsFalse(Number.IsPrime(0));

        [TestMethod]
        public void NumberOneIsPrime() => Assert.IsFalse(Number.IsPrime(1));
    }
}
