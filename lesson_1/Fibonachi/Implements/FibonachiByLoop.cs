namespace lesson_1.Fibonachi.Implements
{
    public class FibonachiByLoop : FibonachiBase
    {
        public override int GetNumberByOrdinal(int number)
        {
            if (number <= 1) return 0;
            if (number == 2) return 1;
            else
            {
                int result = 0;
                int a = 0;
                int b = 1;
                for (int i = 2; i < number; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }  
                return result;
            }
        }
    }
}
