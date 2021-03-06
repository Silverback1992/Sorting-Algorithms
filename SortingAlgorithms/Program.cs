﻿using System;
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

            Console.WriteLine();

            //Calling different sorting algorithms on the list and putting the results into TXTs

            Console.WriteLine("Check on array that has duplicates:");
            Console.WriteLine();

            BubbleSort.BubbleSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            SelectionSort.SelectionSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            //MergeSort.MergeSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            InsertionSort.InsertionSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            BucketSort.BucketSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            QuickSort.QuickSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            GnomeSort.GnomeSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            CombSort.CombSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            CountingSort.CountingSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            HeapSort.HeapSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            //CycleSort.CycleSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            //BogoSort.BogoSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            CocktailSort.CocktailSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            StoogeSort.StoogeSortAlgorithm(new int[] { 2, 4, 5, 3, 1 });
            myTempArray.CopyTo(myArray, 0);

            OddEvenSort.OddEvenSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            BubbleSortRecursive.BubblesortRecursiveAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            //InsertionSortRecursive.InsertionSortRecursiveAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            //ShellSort.ShellSortAlgorithm(myArray);
            myTempArray.CopyTo(myArray, 0);

            StrandSort.StrandSortAlgorithm(new int[]{ 3,5,5,1,5,3,10,8,9});
            myTempArray.CopyTo(myArray, 0);

            //

            Console.ReadKey();
        }

        private static int[] ArrayGenerator()
        {
            int[] myArray = new int[100];
            Random rand = new Random();

            for(int i = 0; i < 100; i++)
            {
                myArray[i] = rand.Next(1, 50);
            }

            return myArray;
        }
    }
}
