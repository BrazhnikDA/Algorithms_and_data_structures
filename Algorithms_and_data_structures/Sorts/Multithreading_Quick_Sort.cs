using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    public class Multithreading_Quick_Sort
    {        
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Splitting(list);
            stopwatch.Stop();
            Console.WriteLine("Multithreading Quick sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");
            return list;
        }

        public static void Splitting(IList<int> list)
        {
            int countThread = Environment.ProcessorCount;   // Количество потоков процессора
            int slice = list.Count / countThread;           // Количество элементов в каждом потоке


            IList<List<int>> data = new List<List<int>>();
            
            for (int i = 0; i < countThread - 1; i++)
            {
                for (int j = 0; j < list.Count;)
                {
                    data.Add(new List<int>());
                    for (int k = 0; k < slice; k++, j++)
                    {
                        if (j < list.Count)
                        {
                            data[i].Add(list[j]);
                        }
                    }
                    i++;
                }
            }

            List<Thread> th = new List<Thread>();
            for (int i = 0; i < data.Count - 1; i++)
            {
                th.Add(new Thread(() => data[i] = (List<int>)QuickSort(data[i])));
                th[i].Start();
            }

            list.Clear();
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < slice; j++)
                {
                    list.Add(data[i][j]);
                }
            }


            th.Add(new Thread(() => QuickSort(list)));
            th[data.Count - 1].Start();
            th[data.Count - 1].Join();
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
