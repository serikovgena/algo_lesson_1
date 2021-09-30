using lesson_1.Fibonachi.Implements;

namespace lesson_1.Fibonachi
{
   public class FibonachiFactory
    {
        public FibonachiBase Create(FibonachiAlgorithm algorithm)
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
