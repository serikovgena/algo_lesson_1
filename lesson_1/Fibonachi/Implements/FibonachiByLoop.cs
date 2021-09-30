namespace lesson_1.Fibonachi.Implements
{
    public class FibonachiByLoop : FibonachiBase
    {
        public override int GetNumberByOrdinal(int number)
        {
            int result = 0;
            for (int i = 0; i <= number; i++)
            {
                result = result + i;
            }
            return result;
        }
    }
}
