using System.Text;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            string[] listOfWords = text.Split(' ');

            ReplaceDuplicateItems(ref listOfWords, "");

            text = String.Join(" ", listOfWords);
        }

        public static void ReplaceDuplicateItems<T>(ref T[] list, T replacer)
        {
            for(int i = 0; i < list.Length; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if ( !(list[i].Equals(" ")) && list[i].Equals(list[j]) )
                    {
                        list[j] = replacer;
                    }
                }
            }
        }
    }
}