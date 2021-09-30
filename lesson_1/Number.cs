namespace lesson_1
{
    internal static class Number
    {
        static public bool IsPrime(int number) => HowManyDivisorsIn(number) == 2;
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
