using System;
using System.Collections.Generic;
using Algorithms_and_data_structures.Sorts;

namespace Algorithms_and_data_structures
{
    class Program
    {
        private const int size = 5000;

        static void Main(string[] args)
        {

            Bubble_Sort.Sort(InputData.CreateData(size));
            Choise_Sort.Sort(InputData.CreateData(size));
        }
    }
}
