using lesson_1.Fibonachi.Implements;

namespace lesson_1.Fibonachi
{
    class FibonachiFactory
    {
        FibonachiAlgorithm algorithm { get; init; }

        public FibonachiFactory(FibonachiAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        public FibonachiBase Create()
        {
            FibonachiBase result = algorithm switch
            {
                FibonachiAlgorithm.Recursion => new FibonachiRecursively(),
                FibonachiAlgorithm.Loop => new FibonachiByLoop(),
                _ => throw new InvalidFibonachiAlgorithm(),
            };
            return result;
        }
    }
}
