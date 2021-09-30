using System;

namespace lesson_1
{
    class Program
    {
        static void Main()
        {
            ShowNumberPrimerIs();
        }
        
        static void ShowNumberPrimerIs()
        {
            var primes = Number.GetAllPrimeNumbersInFirstHundred();
            foreach(var primeNumber in primes)
            {
                Console.Write($"{primeNumber} ");
            }
        }

    }
}
