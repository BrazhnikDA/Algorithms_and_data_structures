using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    public class Quick_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(list);
            stopwatch.Stop();
            Console.WriteLine("Quick sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");
            return list;
        }

        //Метод возвращающий индекс опорного элемента
        static int Partition(IList<int> array, int minIndex, int maxIndex)
        {
            int t;
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    t = array[pivot];
                    array[pivot] = array[i];
                    array[i] = t;
                }
            }

            pivot++;
            t = array[pivot];
            array[pivot] = array[maxIndex];
            array[maxIndex] = t;
            return pivot;
        }

        //Быстрая сортировка
        static IList<int> QuickSort(IList<int> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static IList<int> QuickSort(IList<int> array)
        {
            return QuickSort(array, 0, array.Count - 1);
        }
    }
}
