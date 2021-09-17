using System;
using System.Collections.Generic;
using Algorithms_and_data_structures.Sorts;

namespace Algorithms_and_data_structures
{
    class Program
    {
        private const int size = 10000;

        public static void Main(string[] args)
        {
            Console.WriteLine("Start sorting list on " + size + " elements");
            Bubble_Sort.Sort(InputData.CreateData(size));
            Choise_Sort.Sort(InputData.CreateData(size));
            Inserts_Sort.Sort(InputData.CreateData(size));
            Quick_Sort.Sort(InputData.CreateData(size));
            Merge_Sort.Sort(InputData.CreateData(size));
        }
    }
}
