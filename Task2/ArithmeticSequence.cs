using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int sum = number;

            for (int i = 1; i < count; i++)
            {
                sum += number + add * i;
            }

            return sum;
        }
    }
}
