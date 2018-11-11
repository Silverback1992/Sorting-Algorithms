using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSort : PrintSortingResultToTXT
    {
        public static void BubbleSortAlgorithm(int[] myArray)
        {
            for(int i = 0; i < myArray.Length; i++)
            {
                for(int j = 0; j < myArray.Length - i - 1; j++)
                {
                    if(myArray[j] > myArray[j+1])
                    {
                        Swap(ref myArray[j], ref myArray[j + 1]);
                    }
                }
            }

            PrintSortingResultToTXTFunction(myArray, "BubbleSort");
        }
    }
}
