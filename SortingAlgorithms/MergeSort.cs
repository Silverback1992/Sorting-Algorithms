using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort : PrintSortingResultToTXT
    {
        public static void MergeSortAlgorithm(int[] myArray)
        {
            int[] result = MergeSortRecursion(myArray);

            PrintSortingResultToTXTFunction(result, "MergeSort");
        }

        private static int[] MergeSortRecursion(int[] myArray)
        {
            if(myArray.Length == 1)
            {
                return myArray;
            }

            int center = myArray.Length / 2;
            int[] left = new List<int>(myArray).GetRange(0, center).ToArray();
            int[] right = new List<int>(myArray).GetRange(center, center).ToArray();

            return Merge(MergeSortRecursion(left), MergeSortRecursion(right));
        }

        private static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] result = new int[100];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i != leftArray.Length && j != rightArray.Length)
            {
                if(leftArray[i] < rightArray[j])
                {
                    result[k] = leftArray[i];
                    i++;
                    k++;
                }else
                {
                    result[k] = rightArray[j];
                    j++;
                    k++;
                }
            }

            if(i != leftArray.Length)
            {
                while(i != leftArray.Length)
                {
                    result[k] = leftArray[i];
                    i++;
                    k++;
                }
            }else if(j != rightArray.Length)
            {
                while(j != rightArray.Length)
                {
                    result[k] = rightArray[j];
                    j++;
                    k++;
                }
            }

            return result;
        }
    }
}
