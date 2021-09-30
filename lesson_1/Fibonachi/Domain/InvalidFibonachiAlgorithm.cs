using System;

namespace lesson_1.Fibonachi
{
    internal class InvalidFibonachiAlgorithm : Exception
    {
        public InvalidFibonachiAlgorithm() :
            base("Указан некорректный алгоритм вычисления чиел Фибоначи") { }
    }
}