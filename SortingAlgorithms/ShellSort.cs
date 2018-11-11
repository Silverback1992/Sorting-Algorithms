using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class ShellSort : PrintSortingResultToTXT
    {
        public static void ShellSortAlgorithm(int[] myArray)
        {
            for(int gap=myArray.Length/2; gap>=0; gap/=2)
            {
                for(int i = 0; i < myArray.Length; i++)
                {
                    if(myArray[i] > myArray[i+gap])
                    {
                        Swap(ref myArray[i], ref myArray[i+gap]);
                    }
                }

                int end = myArray.Length - 1;

                for(int i = 0; i < end; i+=gap)
                {
                    if(myArray[i] > myArray[gap+i])
                    {
                        Swap(ref myArray[i], ref myArray[gap + i]);
                    }
                }
            }
        }
    }
}
