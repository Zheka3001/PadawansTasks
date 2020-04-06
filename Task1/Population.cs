using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int year;

            for (year = 0; initialPopulation <= currentPopulation; year++)
            {
                initialPopulation += visitors + (int) (initialPopulation * (percent / 100));
            }

            return year;
        }
    }
}