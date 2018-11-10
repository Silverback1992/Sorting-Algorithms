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
    }
}
