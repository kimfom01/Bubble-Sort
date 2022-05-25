using System;
using System.Diagnostics;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 20000;

            int[] randNumb = new int[size];

            for (int i = 0; i < size; i++){
                randNumb[i] = rnd.Next(100);
            }

            string[] arr = new string[] { "kim", "john", "abigail", "bimbo", "yenebon" };

            // Sort Integers
            BubbleSort(randNumb);

            // Sort Strings
            BubbleSort(arr);

            // Print strings
            foreach (string item in arr)
            {
                Console.WriteLine(item);   
            }
        }

        static void BubbleSortintegers(int[] Element)
        {
            for (int i = 0; i < Element.Length - 1; i++)
            {
                for (int j = 0; j < Element.Length - i - 1; j++)
                {
                    int tmp;
                    if (Element[j] > Element[j + 1])
                    {
                        tmp = Element[j];
                        Element[j] = Element[j + 1];
                        Element[j + 1] = tmp;
                    }
                }
            }
        }

        static void BubbleSortStrings(string[] Element)
        {
            for (int i = 0; i < Element.Length - 1; i++)
            {
                for (int j = 0; j < Element.Length - i - 1; j++)
                {
                    string tmp;
                    if (Element[j][0] > Element[j + 1][0])
                    {
                        tmp = Element[j];
                        Element[j] = Element[j + 1];
                        Element[j + 1] = tmp;
                    }
                }
            }
        }
    }
}