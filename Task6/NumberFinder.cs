using System;
using System.Collections.Generic;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            string listOfNums = number.ToString();
            int i = listOfNums.Length - 1;

            while (i > 0)
            {
                if (listOfNums[i] == listOfNums[i - 1])
                {
                    i--;
                    continue;
                }
                else if (i + 1 == listOfNums.Length)
                {
                    return int.Parse(listOfNums.Substring(0, i - 1) + listOfNums[i] + listOfNums[i - 1]);

                }
                else
                {
                    return int.Parse(listOfNums = listOfNums.Substring(0, i - 1) + listOfNums[i] + listOfNums[i - 1] +
                                 listOfNums.Substring(i + 1));

                }

            }

            return null;
        }
    }
}
