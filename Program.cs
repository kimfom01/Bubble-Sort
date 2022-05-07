using System;
using System.Diagnostics;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Random rnd = new Random();
            int size = 20000;

            int[] randNumb = new int[size];

            for (int i = 0; i < size; i++){
                randNumb[i] = rnd.Next(100);
            }

            stopWatch.Start();
            BubbleSort(randNumb);
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        static void BubbleSort(int[] Element)
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
    }
}