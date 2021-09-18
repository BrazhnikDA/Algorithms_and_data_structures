using System;
using System.Collections.Generic;
using Algorithms_and_data_structures.Sorts;

namespace Algorithms_and_data_structures
{
    class Program
    {
        private const int size = 100000;

        public static void Main(string[] args)
        {
            Console.WriteLine("Start sorting list on " + size + " elements");
            Bubble_Sort.Sort(InputData.CreateData(size));
            Choise_Sort.Sort(InputData.CreateData(size));
            Inserts_Sort.Sort(InputData.CreateData(size));
            Dwarf_Sort.Sort(InputData.CreateData(size));
            Quick_Sort.Sort(InputData.CreateData(size));
            Multithreading_Quick_Sort.Sort(InputData.CreateData(size));
            Merge_Sort.Sort(InputData.CreateData(size));
            Shell_Sort.Sort(InputData.CreateData(size));

            Console.WriteLine("Количество потоков у прцоессора(ядер): {0}", Environment.ProcessorCount);

        }
    }
}
