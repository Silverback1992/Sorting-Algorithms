using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BucketSort : PrintSortingResultToTXT
    {
        public static void BucketSortAlgorithm(int[] myArray)
        {
            List<int>[] buckets = new List<int>[10]; 

            for(int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            int bucketID;

            for(int i = 0; i < myArray.Length; i++)
            {
                bucketID = myArray[i] / 100;

                if (bucketID == 10)
                    bucketID = 9;

                buckets[bucketID].Add(myArray[i]);
            }

            for(int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = InsertionSortAlgorithm(buckets[i]);
            }

            List<int> result = new List<int>();

            for(int i = 0; i < buckets.Length; i++)
            {
                result.AddRange(buckets[i]);
            }

            PrintSortingResultToTXTFunction(result.ToArray(), "BucketSort");
        }

        private static List<int> InsertionSortAlgorithm(List<int> myArray)
        {
            int currentValue;
            int position;

            for(int i = 1; i < myArray.Count; i++)
            {
                currentValue = myArray[i];
                position = i;

                while(position > 0 && myArray[position - 1] > currentValue)
                {
                    myArray[position] = myArray[position - 1];
                    position = position - 1;
                }

                myArray[position] = currentValue;
            }

            return myArray;
        }
    }
}
