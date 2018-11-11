using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class StoogeSort : PrintSortingResultToTXT
    {
        public static void StoogeSortAlgorithm(int[] myArray)
        {
            StoogeSortRecursive(ref myArray, 0, myArray.Length - 1);
            PrintSortingResultToTXTFunction(myArray, "StoogeSort");
        }

        private static void StoogeSortRecursive(ref int[] myArray, int start, int end)
        {
            if (start >= end)
                return;

            if(myArray[start] > myArray[end])
                Swap(ref myArray[start], ref myArray[end]);

            if(end - start + 1 > 2)
            {
                int oneThird = (end - start + 1) / 3;

                StoogeSortRecursive(ref myArray, start, end - oneThird);
                StoogeSortRecursive(ref myArray, start + oneThird, end);
                StoogeSortRecursive(ref myArray, start, end - oneThird);
            }
        }
    }
}
