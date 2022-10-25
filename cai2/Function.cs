using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cai2
{
    public static class Function
    {
        public static int GetFitnessFunction(int x)
        {
            return 62 - 57 * x - 97 * x * x + 5 * x * x * x;
        } 

        public static int GetMin()
        {
            int min;
            int minIndex;
            min = GetFitnessFunction(-10);
            minIndex = -10;
            for (int i = -10; i < 53; i++)
            {
                if (GetFitnessFunction(i) < min)
                {
                    min = GetFitnessFunction(i);
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}
