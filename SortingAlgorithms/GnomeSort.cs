using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class GnomeSort : PrintSortingResultToTXT
    {
        public static void GnomeSortAlgorithm(int[] myArray)
        {
            int counter = 0;

            while(counter < myArray.Length)
            {
                if(counter == 0 || myArray[counter] > myArray[counter-1])
                {
                    counter++;
                }else
                {
                    Swap(ref myArray[counter], ref myArray[counter - 1]);
                    counter--;
                }
            }

            PrintSortingResultToTXTFunction(myArray, "GnomeSort");
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
