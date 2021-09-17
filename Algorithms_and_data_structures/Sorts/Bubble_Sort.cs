using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms_and_data_structures.Sorts
{
    public class Bubble_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0 + i; j < list.Count; j++)
                {
                    if(list[i] > list[j])
                    {
                        int tmp = list[j];
                        list[j] = list[i];
                        list[i] = tmp;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Bubble sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");

            return list;
        }
    }
}
