using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    internal static class OnotationExample
    {
        public static int StrangeSum(int[] inputArray) // Асимптотическая сложность функции => O(n^3)
        {
            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++) // O(n)
            {
                for (int j = 0; j < inputArray.Length; j++) // O(n)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(n)
                    {
                        int y = 0; // O(1)

                        if (j != 0) // O(1)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y; // O(1)
                    }
                }
            }
            return sum;
        }
    }
}

