using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class CombSort : PrintSortingResultToTXT
    {
        public static void CombSortAlgorithm(int[] myArray)
        {
            int gap = myArray.Length;

            bool swapped = true;

            while(gap >= 1 || swapped == true)
            {
                gap = gap * 10 / 13;
                swapped = false;

                for(int i = 0; i < myArray.Length - gap; i++)
                {
                    if(myArray[i] > myArray[i+gap])
                    {
                        Swap(ref myArray[i], ref myArray[gap + i]);
                        swapped = true;
                    }
                }
            }

            PrintSortingResultToTXTFunction(myArray, "CombSort");
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
