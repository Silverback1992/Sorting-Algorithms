using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort : PrintSortingResultToTXT
    {
        public static void QuickSortAlgorithm(int[] myArray)
        {
            QuickSortRecursive(myArray, 0, myArray.Length - 1);

            PrintSortingResultToTXTFunction(myArray, "QuickSort");
        }

        private static void QuickSortRecursive(int[] myArray, int lower, int higher)
        {
            if(lower < higher)
            {
                int pi = Partition(myArray, lower, higher);
                QuickSortRecursive(myArray, lower, pi-1);
                QuickSortRecursive(myArray, pi+1, higher);
            }
        }

        private static int Partition(int[] myArray, int lower, int higher)
        {
            int pivot = myArray[higher];
            int i = lower - 1;

            for(int j = lower; j < higher; j++)
            {
                if(myArray[j] <= pivot)
                {
                    i++;

                    Swap(ref myArray[i], ref myArray[j]);
                }
            }

            Swap(ref myArray[i + 1], ref myArray[higher]);

            return i+1;
        }
    }
}
