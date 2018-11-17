using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class StrandSort : PrintSortingResultToTXT
    {
        public static void StrandSortAlgorithm(int[] myArray)
        {
            List<int> ip = myArray.ToList();
            List<int> op = new List<int>();

            StrandSortRecursive(ip, op);

            PrintSortingResultToTXTFunction(op.ToArray(), "StrandSort");
        }

        private static void StrandSortRecursive(List<int> ip, List<int> op)
        {
            if (ip.Count == 0)
                return;

            List<int> subList = new List<int>();

            subList.Add(ip.First());
            ip.Remove(ip.First());

            foreach(int element in ip.ToList())
            {
                if(element > subList.Last())
                {
                    subList.Add(element);
                    ip.Remove(element);
                }
            }

            op = MergeLists(subList, op);

            StrandSortRecursive(ip, op);
        }

        private static List<int> MergeLists(List<int> subList, List<int> op)
        {
            List<int> tempList = new List<int>();

            while(subList.Count != 0 && op.Count != 0)
            {
                if(subList.First() > op.First())
                {
                    tempList.Add(op.First());
                    op.Remove(op.First());
                }
                else if(subList.First() < op.First())
                {
                    tempList.Add(subList.First());
                    subList.Remove(subList.First());
                }
                else
                {
                    tempList.Add(subList.First());
                    tempList.Add(op.First());
                    subList.Remove(subList.First());
                    op.Remove(op.First());
                }
            }

            if(subList.Count == 0)
            {
                tempList.AddRange(op);
            }
            else if(op.Count == 0)
            {
                tempList.AddRange(subList);
            }

            return tempList;
        }
    }
}
