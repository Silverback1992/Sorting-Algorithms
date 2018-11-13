using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingAlgorithms
{
    class PrintSortingResultToTXT
    {
        protected static void PrintSortingResultToTXTFunction(int[] myArray, string nameOfSortingMethod)
        {
            sortCheck(myArray, nameOfSortingMethod);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\alin2\source\repos\SortingAlgorithms\SortingAlgorithms\" + 
                nameOfSortingMethod + "Results.txt"))
            {
                sw.WriteLine(nameOfSortingMethod + " Results:");

                foreach (int element in myArray)
                {
                    sw.WriteLine(element);
                }
            }
        }

        protected static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void sortCheck(int[] myArray, string nameOfSortingMethod)
        {
            bool isCorrect = true;

            for(int i = 0; i < myArray.Length - 1; i++)
            {
                if(myArray[i] > myArray[i+1])
                {
                    isCorrect = false;
                }
            }

            Console.WriteLine(nameOfSortingMethod + " successful: {0}", isCorrect ? "Yes" : "No");
        }
    }
}
