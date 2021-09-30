using lesson_1.Fibonachi;
using System;

namespace lesson_1
{
    class Program
    {
        static void Main()
        {
            ShowNumberPrimerIs();
            ShowFibonachi();
        }
        
        static void ShowNumberPrimerIs()
        {
            var primes = Number.GetAllPrimeNumbersInFirstHundred();
            foreach(var primeNumber in primes)
            {
                Console.Write($"{primeNumber} ");
            }
        }

        static void ShowFibonachi()
        {
            var factory = new FibonachiFactory();
            var generator = factory.Create(FibonachiAlgorithm.Recursion);

            for (int n = 1; n < 10; n++)
                Console.Write($"{generator.GetNumberByOrdinal(n)} ");
            
            Console.WriteLine();
            
            generator = factory.Create(FibonachiAlgorithm.Loop);

            for (int n = 1; n < 10; n++)
                Console.Write($"{generator.GetNumberByOrdinal(n)} ");
        }
    }
}
