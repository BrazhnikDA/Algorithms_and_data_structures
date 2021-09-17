using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    public class Shell_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            ShellSort(list);
            
            stopwatch.Stop();
            Console.WriteLine("Shell sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");
            return list;
        }

        static IList<int> ShellSort(IList<int> list)
        {
            // Расстояние между элементами, которые сравниваются
            var d = list.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < list.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (list[j - d] > list[j]))
                    {
                        int t = list[j];
                        list[j] = list[j - d];
                        list[j - d] = t;
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return list;
        }
    }
}
