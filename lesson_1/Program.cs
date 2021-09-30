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
            for (int i = 0; i < 100; i++)
            {
                if(Number.IsPrime(i))
                {
                    Console.Write($"{i} ");
                }            
            }
          
        }
    }
}
