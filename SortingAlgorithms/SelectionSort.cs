using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSort : PrintSortingResultToTXT
    {
        public static void SelectionSortAlgorithm(int[] myArray)
        {
            int indexOfMin;

            for(int i = 0; i < myArray.Length; i++)
            {
                indexOfMin = i;

                for(int j = i + 1; j < myArray.Length; j++)
                {
                    if(myArray[indexOfMin] > myArray[j])
                    {
                        indexOfMin = j;
                    }
                }

                if(i != indexOfMin)
                {
                    Swap(ref myArray[indexOfMin], ref myArray[i]);
                }
            }

            PrintSortingResultToTXTFunction(myArray, "SelectionSort");
        }
    }
}
