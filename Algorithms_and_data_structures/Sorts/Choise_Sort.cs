using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms_and_data_structures.Sorts
{
    public class Choise_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                int dummy = list[i];
                list[i] = list[min];
                list[min] = dummy;
            }

            stopwatch.Stop();
            Console.WriteLine("Choise sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");

            return list;
        }
    }
}
