using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BogoSort : PrintSortingResultToTXT
    {
        public static void BogoSortAlgorithm(int[] myArray)
        {
            while(!IsSorted(myArray))
            {
                Shuffle(ref myArray);
            }

            PrintSortingResultToTXTFunction(myArray, "BogoSort");
        }

        private static bool IsSorted(int[] myArray)
        {
            bool isSorted = true;

            for(int i = 0; i < myArray.Length - 1; i++)
            {
                if(myArray[i] >= myArray[i+1])
                {
                    isSorted = false;
                }
            }

            return isSorted;
        }

        private static void Shuffle(ref int[] myArray)
        {
            Random myRandom = new Random();

            for(int i = 0; i < myArray.Length; i++)
            {
                Swap(ref myArray[i], ref myArray[myRandom.Next(0, myArray.Length)]);
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
