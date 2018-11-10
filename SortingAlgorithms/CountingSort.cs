using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class CountingSort : PrintSortingResultToTXT
    {
        public static void CountingSortAlgorithm(int[] myArray)
        {
            int[] sortedArray = new int[myArray.Length];
            int minVal = myArray[0];
            int maxVal = myArray[0];

            for(int i = 1; i < myArray.Length; i++)
            {
                if(minVal > myArray[i])
                {
                    minVal = myArray[i];
                }

                if(maxVal < myArray[i])
                {
                    maxVal = myArray[i];
                }
            }

            int[] counts = new int[maxVal - minVal + 1];

            for(int i = 0; i < myArray.Length; i++)
            {
                counts[myArray[i] - minVal]++;
            }

            counts[0]--;
            for(int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for(int i = myArray.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[myArray[i] - minVal]--] = myArray[i];
            }

            PrintSortingResultToTXTFunction(sortedArray, "CountingSort");
        }
    }
}
