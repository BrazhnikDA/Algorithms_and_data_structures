using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    internal class Inserts_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (var i = 1; i < list.Count; i++)
            {
                var key = list[i];
                var j = i;
                while ((j > 1) && (list[j - 1] > key))
                {
                    var temp = list[j - 1];
                    list[j - 1] = list[j];
                    list[j] = temp;
                    j--;
                }

                list[j] = key;
            }

            stopwatch.Stop();
            Console.WriteLine("Inserts sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");
            return list;
        }
    }
}
