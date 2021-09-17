using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    public class Inserts_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < list.Count - 1; i++)
            {
                var key = i + 1;
                var temp = list[key];
                for (int j = i + 1; j > 0; j--)
                {
                    if (temp < list[j - 1])
                    {
                        list[j] = list[j - 1];
                        key = j - 1;
                    }
                }
                list[key] = temp;
            }

            stopwatch.Stop();
            Console.WriteLine("Inserts sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");
            return list;
        }        
        
    }
}
