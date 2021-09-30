using System;
using System.Runtime.Serialization;

namespace lesson_1.Fibonachi
{
    [Serializable]
    internal class InvalidFibonachiAlgorithm : Exception
    {
        public InvalidFibonachiAlgorithm() :
            base("Указан некорректный алгоритм вычисления чиел Фибоначи") { }
    }
}