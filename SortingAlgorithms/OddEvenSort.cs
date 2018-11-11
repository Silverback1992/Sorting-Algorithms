using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class OddEvenSort : PrintSortingResultToTXT
    {
        public static void OddEvenSortAlgorithm(int[] myArray)
        {
            bool isSorted = false;

            while(!isSorted)
            {
                isSorted = true;

                for(int i = 1; i < myArray.Length - 1; i+=2)
                {
                    if(myArray[i] > myArray[i+1])
                    {
                        Swap(ref myArray[i], ref myArray[i + 1]);
                        isSorted = false;
                    }
                }

                for(int j = 0; j < myArray.Length - 1; j+=2)
                {
                    if(myArray[j] > myArray[j+1])
                    {
                        Swap(ref myArray[j], ref myArray[j + 1]);
                        isSorted = false;
                    }
                }
            }

            PrintSortingResultToTXTFunction(myArray, "OddEvenSort");
        }
    }
}
