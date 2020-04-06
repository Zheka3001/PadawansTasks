using System;
using NUnit.Framework.Constraints;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            int absA = Math.Abs(a);
            int absB = Math.Abs(b);

            int max = Math.Min(absA, absB);

            if ((absA % max == 0) & (absB % max == 0))
            {
                return max;
            }

            for (int i = max / 2; i > 1; i--)
            {
                if ((absA % i == 0) & (absB % i == 0))
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
