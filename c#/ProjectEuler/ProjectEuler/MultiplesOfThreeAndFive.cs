using System.Collections.Generic;

namespace ProjectEuler
{
    public static class MultiplesOfThreeAndFive
    {
        public static List<int> GetMultipleOfThreeAndFive(int value)
        {
            var multiplesOfThreeAndFive = new List<int>();

            for (var i = 1; i <= value; i++)
            {
                if (i % 3 == 0)
                {
                    multiplesOfThreeAndFive.Add(i);
                    continue;
                }

                if (i % 5 == 0)
                {
                    multiplesOfThreeAndFive.Add(i);
                }
            }

            return multiplesOfThreeAndFive;
        }
    }
}
