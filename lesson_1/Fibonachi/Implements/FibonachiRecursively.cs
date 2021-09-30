namespace lesson_1.Fibonachi.Implements
{
   public class FibonachiRecursively : FibonachiBase
    {
        public override int GetNumberByOrdinal(int number)
        {
            if (number <= 1) return 0;
            if (number == 2) return 1;
            else
                return GetNumberByOrdinal(number - 2) + GetNumberByOrdinal(number - 1);
        }
    }
}
