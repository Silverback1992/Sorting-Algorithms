using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class CycleSort : PrintSortingResultToTXT
    {
        public static void CycleSortAlgorithm(int[] myArray)
        {
            int numberOfSmallerNums = 1;
            int myIndex = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                while (numberOfSmallerNums != 0)
                {
                    numberOfSmallerNums = 0;

                    for (int j = myIndex + 1; j < myArray.Length; j++)
                    {
                        if (myArray[myIndex] > myArray[j])
                        {
                            numberOfSmallerNums++;
                        }
                    }

                    Swap(ref myArray[myIndex], ref myArray[numberOfSmallerNums]);
                }

                myIndex++;
            }

            PrintSortingResultToTXTFunction(myArray, "CycleSort");
        }
    }
}
