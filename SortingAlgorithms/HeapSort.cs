using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class HeapSort : PrintSortingResultToTXT
    {
        public static void HeapSortAlgorithm(int[] myArray)
        {
            for(int i = myArray.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(myArray, myArray.Length, i);
            }

            for(int i = myArray.Length - 1; i >= 0; i--)
            {
                Swap(ref myArray[0], ref myArray[i]);
                Heapify(myArray, i, 0);
            }

            PrintSortingResultToTXTFunction(myArray, "HeapSort");
        }

        private static void Heapify(int[] myArray, int arrayLength, int parentNodeIndex)
        {
            int largestNodeIndex = parentNodeIndex;
            int leftChildNodeIndex = 2 * parentNodeIndex + 1;
            int rightChildNodeIndex = 2 * parentNodeIndex + 2;

            if(leftChildNodeIndex < arrayLength && myArray[leftChildNodeIndex] > myArray[largestNodeIndex])
            {
                largestNodeIndex = leftChildNodeIndex;
            }

            if(rightChildNodeIndex < arrayLength && myArray[rightChildNodeIndex] > myArray[largestNodeIndex])
            {
                largestNodeIndex = rightChildNodeIndex;
            }

            if(largestNodeIndex != parentNodeIndex)
            {
                Swap(ref myArray[largestNodeIndex], ref myArray[parentNodeIndex]);
                Heapify(myArray, arrayLength, largestNodeIndex);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
