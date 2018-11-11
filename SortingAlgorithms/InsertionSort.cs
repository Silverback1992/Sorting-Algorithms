using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertionSort : PrintSortingResultToTXT
    {
        public static void InsertionSortAlgorithm(int[] myArray)
        {
            int currentValue;
            int position;

            for(int i = 1; i < myArray.Length; i++)
            {
                currentValue = myArray[i];
                position = i;

                while(position > 0 && myArray[position-1] > currentValue)
                {
                    myArray[position] = myArray[position - 1];
                    position -= 1;
                }

                myArray[position] = currentValue;
            }

            PrintSortingResultToTXTFunction(myArray, "InsertionSort");
        }
    }
}
