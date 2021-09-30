using System.Collections.Generic;

namespace lesson_1
{
    public static class Number
    {
        static public bool IsPrime(int number) => HowManyDivisorsIn(number) == 2;
       
        static public int[] GetAllPrimeNumbersInFirstHundred()
        {
            var primeNumbersList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (IsPrime(i)) primeNumbersList.Add(i);
            }
            return primeNumbersList.ToArray();
        }
        static public int HowManyDivisorsIn(int number)
        {
            int divisors = 0;
            int it = 1;

            while (it <= number)
            {
                if((number % it) == 0)
                {
                    divisors++;
                }
                it++;
            }
            return divisors;
        }
    }
}
