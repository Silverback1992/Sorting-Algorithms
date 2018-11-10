using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate random 1D array

            int[] myArray = ArrayGenerator();

            //Print the unsorted list to the console so it can be checked

            Console.WriteLine("Unsorted list:");

            foreach(int element in myArray)
            {
                Console.WriteLine(element);
            }

            //Calling different sorting algorithms on the list and putting the results into TXTs

            BubbleSort.BubbleSortAlgorithm(myArray);
            SelectionSort.SelectionSortAlgorithm(myArray);
            //MergeSort.MergeSortAlgorithm(myArray);
            InsertionSort.InsertionSortAlgorithm(myArray);
            BucketSort.BucketSortAlgorithm(myArray);
            QuickSort.QuickSortAlgorithm(myArray);
            GnomeSort.GnomeSortAlgorithm(myArray);
            CombSort.CombSortAlgorithm(myArray);
            CountingSort.CountingSortAlgorithm(myArray);
            HeapSort.HeapSortAlgorithm(myArray);
            //CycleSort.CycleSortAlgorithm(myArray);
            BogoSort.BogoSortAlgorithm(myArray);
            CocktailSort.CocktailSortAlgorithm(myArray);
            StoogeSort.StoogeSortAlgorithm(new int[] { 2, 4, 5, 3, 1 });
            OddEvenSort.OddEvenSortAlgorithm(myArray);

            //

            Console.ReadKey();
        }

        private static int[] ArrayGenerator()
        {
            int[] myArray = new int[100];
            Random rand = new Random();
            bool isItUnique = true;

            for(int i = 0; i < 100; i++)
            {
                myArray[i] = rand.Next(1, 1001);

                while (!isItUnique)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if(myArray[i] == myArray[j])
                        {
                            isItUnique = false;
                            myArray[i] = rand.Next(1, 1001);
                            break;
                        }else
                        {
                            isItUnique = true;
                        }
                    }
                }

                isItUnique = false;
            }

            return myArray;
        }
    }
}
