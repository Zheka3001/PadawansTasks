using System;
using System.Runtime.InteropServices.WindowsRuntime;
using NUnit.Framework;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            int count = 0;
            string vowels = "aeiou";

            foreach (var t in vowels)
            {
                foreach (var l in str)
                {
                    if (t == l)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
