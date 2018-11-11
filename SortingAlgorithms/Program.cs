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
            /*
            myArray[0] = 1000000;
            //myArray = myTempArray;

            Console.WriteLine("myArray:");
            Console.WriteLine();

            foreach(int element in myArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("myTempArray:");
            Console.WriteLine();

            foreach (int element in myTempArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
            //myArray.CopyTo(myTempArray, 0);
            */

            //Print the unsorted list to the console so it can be checked

            Console.WriteLine("Unsorted list:");

            foreach(int element in myArray)
            {
                Console.WriteLine(element);
            }

            //Calling different sorting algorithms on the list and putting the results into TXTs

            BubbleSort.BubbleSortAlgorithm(myArray);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Before Check1:");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Check1");
            myArray = myTempArray;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("myArray:");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            SelectionSort.SelectionSortAlgorithm(myArray);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Check2");
            foreach(int element in myTempArray)
            {
                Console.WriteLine(element);
            }
            myArray = myTempArray;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("myArray:");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
            //MergeSort.MergeSortAlgorithm(myArray);
            InsertionSort.InsertionSortAlgorithm(myArray);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Check3");
            myArray = myTempArray;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("myArray:");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            BucketSort.BucketSortAlgorithm(myArray);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Check4");
            myArray = myTempArray;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("myArray:");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            QuickSort.QuickSortAlgorithm(myArray);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Check5");
            myArray = myTempArray;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("myArray:");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
            GnomeSort.GnomeSortAlgorithm(myArray);
            Console.WriteLine("check6");
            CombSort.CombSortAlgorithm(myArray);
            Console.WriteLine("check7");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CheckSOKADIK");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            myArray = myTempArray;
            Console.WriteLine();
            Console.WriteLine();
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            CountingSort.CountingSortAlgorithm(myArray);
            HeapSort.HeapSortAlgorithm(myArray);
            //CycleSort.CycleSortAlgorithm(myArray);
            BogoSort.BogoSortAlgorithm(myArray);
            CocktailSort.CocktailSortAlgorithm(myArray);
            StoogeSort.StoogeSortAlgorithm(new int[] { 2, 4, 5, 3, 1 });
            OddEvenSort.OddEvenSortAlgorithm(myArray);
            BubbleSortRecursive.BubblesortRecursiveAlgorithm(myArray);

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
