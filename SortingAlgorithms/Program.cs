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
            int[] myTempArray = new int[myArray.Length];
            Array.Copy(myArray, myTempArray, myArray.Length);

            //Print the unsorted list to the console so it can be checked

            Console.WriteLine("Unsorted list:");

            foreach(int element in myArray)
            {
                Console.WriteLine(element);
            }

            //Calling different sorting algorithms on the list and putting the results into TXTs

            BubbleSort.BubbleSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            SelectionSort.SelectionSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            //MergeSort.MergeSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            InsertionSort.InsertionSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            BucketSort.BucketSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            QuickSort.QuickSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            GnomeSort.GnomeSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            CombSort.CombSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            CountingSort.CountingSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            HeapSort.HeapSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            //CycleSort.CycleSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            //BogoSort.BogoSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            CocktailSort.CocktailSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            StoogeSort.StoogeSortAlgorithm(new int[] { 2, 4, 5, 3, 1 });
            myTempArray.CopyTo(myArray, 0);

            OddEvenSort.OddEvenSortAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

            BubbleSortRecursive.BubblesortRecursiveAlgorithm(myArray);
            CheckIfArrayRandomOrSorted(myArray);
            myTempArray.CopyTo(myArray, 0);
            CheckIfArrayRandomOrSorted(myArray);

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

        private static void CheckIfArrayRandomOrSorted(int[] myArray)
        {
            bool isRandom = false;

            for(int i = 0; i < myArray.Length - 1; i++)
            {
                if(myArray[i] > myArray[i+1])
                {
                    isRandom = true;
                    Console.WriteLine("The array values are random.");
                    break;
                }
            }

            if(!isRandom)
            {
                Console.WriteLine("The array is sorted.");
            }
        }
    }
}
