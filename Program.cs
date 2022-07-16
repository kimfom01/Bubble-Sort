using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 10;

            int[] randNumb = new int[size];

            for (int i = 0; i < size; i++){
                randNumb[i] = rnd.Next(100);
            }

            string[] arr = new string[] { "kim", "jonathan", "john", "abigail", "bimbo", "yenebon" };

            // Sort Integers
            BubbleSortIntegers(randNumb);

            // Sort Strings
            BubbleSortStrings(arr);

            // Print strings
            foreach (string item in arr)
            {
                Console.WriteLine(item);   
            }
        }

        static void BubbleSortIntegers(int[] Element)
        {
            for (int i = 1; i < Element.Length - 1; i++)
            {
                for (int j = Element.Length - 1; j >= i; j--)
                {
                    int tmp;
                    if (Element[j] < Element[j - 1])
                    {
                        tmp = Element[j];
                        Element[j] = Element[j - 1];
                        Element[j - 1] = tmp;
                    }
                }
            }
        }

        static void BubbleSortStrings(string[] Element)
        {
            for (int i = 1; i < Element.Length - 1; i++)
            {
                for (int j = Element.Length - 1; j >= i; j--)
                {
                    string tmp;
                    if (Element[j].CompareTo(Element[j - 1]) < 0)
                    {
                        tmp = Element[j];
                        Element[j] = Element[j - 1];
                        Element[j - 1] = tmp;
                    }
                }
            }
        }
    }
}