using System;
using System.Collections.Generic;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Length > array[j + 1].Length)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        static void Swap(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }
}
