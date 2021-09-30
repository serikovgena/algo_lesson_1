using System;

namespace lesson_1
{
    class Program
    {
        static void Main()
        {
            ShowNumberPrimerIs();
<<<<<<< HEAD
=======
        }
        
        static void ShowNumberPrimerIs()
        {
            for (int i = 0; i < 100; i++)
            {
                if(Number.IsPrime(i))
                {
                    Console.Write($"{i} ");
                }            
            }
          
>>>>>>> e893b89685b7c0ef4d0de32293d9c7e5d1ca15c1
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
