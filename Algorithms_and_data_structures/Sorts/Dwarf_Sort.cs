using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    public class Dwarf_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            GnomeSort(list);

            stopwatch.Stop();
            Console.WriteLine("Dwarf sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");
            return list;
        }

        static IList<int> GnomeSort(IList<int> list)
        {
            int index = 1;
            int nextIndex = index + 1;

            while (index < list.Count)
            {
                if (list[index - 1] < list[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    int temp = list[index - 1];
                    list[index - 1] = list[index];
                    list[index] = temp;
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return list;
        }
    }
}
