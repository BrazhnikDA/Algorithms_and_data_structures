using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    class Merge_Sort
    {
        public static IList<int> Sort(IList<int> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MergeSort(list);
            stopwatch.Stop();
            Console.WriteLine("Merge sort is Time: " + stopwatch.ElapsedMilliseconds + "ms");
            return list;
        }

        static void Merge(IList<int> list, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (list[left] < list[right])
                {
                    tempArray[index] = list[left];
                    left++;
                }
                else
                {
                    tempArray[index] = list[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = list[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = list[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                list[lowIndex + i] = tempArray[i];
            }
        }

        //Сортировка слиянием
        static IList<int> MergeSort(IList<int> list, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(list, lowIndex, middleIndex);
                MergeSort(list, middleIndex + 1, highIndex);
                Merge(list, lowIndex, middleIndex, highIndex);
            }

            return list;
        }

        static IList<int> MergeSort(IList<int> list)
        {
            return MergeSort(list, 0, list.Count - 1);
        }

    }
}
