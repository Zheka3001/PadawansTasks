using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            for (int i = 0, j = source.Length - 1; i < j; i++, j--)
            {
                if (source[i] != source[j])
                {
                    return "No";
                }
            }

            return "Yes";
        }
    }
}
