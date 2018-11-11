using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertionSortRecursive : PrintSortingResultToTXT
    {
        public static void InsertionSortRecursiveAlgorithm(int[] myArray)
        {
            int i = 1;
            InsertionSortRecursiveSolution(myArray, i);

            PrintSortingResultToTXTFunction(myArray, "InsertionSortRecursive");
        }

        private static void InsertionSortRecursiveSolution(int[] myArray, int i)
        {
            if (i == myArray.Length - 1)
                return;

            int currentValue = myArray[i];
            int position = i;

            while(position > 0 && myArray[position-1] > currentValue)
            {
                myArray[position] = myArray[position - 1];
                position -= 1;
            }

            myArray[i] = currentValue;

            InsertionSortRecursiveSolution(myArray, i++);
        }
    }
}
