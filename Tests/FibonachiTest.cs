using lesson_1.Fibonachi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FibonachiTestRecurcively
    {
        FibonachiFactory factory;
        public FibonachiTestRecurcively()
        {
            factory = new FibonachiFactory();
        }

        [TestMethod]
        public void TestRecursevelyAlgo()
        {
            var fibonachi = factory.Create(FibonachiAlgorithm.Recursion);
            Assert.IsTrue(fibonachi.GetNumberByOrdinal(1) == 0);
            Assert.IsTrue(fibonachi.GetNumberByOrdinal(2) == 1);
            Assert.IsTrue(fibonachi.GetNumberByOrdinal(10) == 34);
        }

        [TestMethod]
        public void TestLoopAlgo()
        {
            var fibonachi = factory.Create(FibonachiAlgorithm.Loop);
            Assert.IsTrue(fibonachi.GetNumberByOrdinal(1) == 0);
            Assert.IsTrue(fibonachi.GetNumberByOrdinal(2) == 1);
            Assert.IsTrue(fibonachi.GetNumberByOrdinal(10) == 34);
        }
    }
}
