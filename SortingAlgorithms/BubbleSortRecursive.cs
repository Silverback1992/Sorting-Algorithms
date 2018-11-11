using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSortRecursive : PrintSortingResultToTXT
    {
        public static void BubblesortRecursiveAlgorithm(int[] myArray)
        {
            int n = myArray.Length;
            BubbleSortRecursiveSolution(myArray, n);

            PrintSortingResultToTXTFunction(myArray, "BubbleSortRecursive");
        }

        private static void BubbleSortRecursiveSolution(int[] myArray, int n)
        {
            if (n == 1)
                return;

            for(int i = 0; i < n - 1; i++)
            {
                if(myArray[i] > myArray[i+1])
                {
                    Swap(ref myArray[i], ref myArray[i + 1]);
                }
            }

            BubbleSortRecursiveSolution(myArray, n - 1);
        }
    }
}
