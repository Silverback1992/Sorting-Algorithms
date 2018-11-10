using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class CocktailSort : PrintSortingResultToTXT
    {
        public static void CocktailSortAlgorithm(int[] myArray)
        {
            bool swapped = true;
            int elementsSortedOnTheRight = 0;
            int elementsSortedOnTheLeft = 0;

            while(swapped)
            {
                swapped = false;

                for (int i = elementsSortedOnTheLeft; i < myArray.Length - elementsSortedOnTheRight - 1; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        Swap(ref myArray[i], ref myArray[i + 1]);
                        swapped = true;
                    }
                }

                elementsSortedOnTheRight++;

                for(int j = myArray.Length - 1 - elementsSortedOnTheRight; j > elementsSortedOnTheLeft; j--)
                {
                    if(myArray[j] < myArray[j-1])
                    {
                        Swap(ref myArray[j], ref myArray[j - 1]);
                        swapped = true;
                    }
                }

                elementsSortedOnTheLeft++;
            }

            PrintSortingResultToTXTFunction(myArray, "CocktailSort");
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
