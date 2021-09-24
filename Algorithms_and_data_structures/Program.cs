using Algorithms_and_data_structures.Data_Structures.List;
using System;

namespace Algorithms_and_data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int[] a = { 2, 3, 4, 5, 6, 7 };
            list.Add(3);
            list.Add(a);

            // Проверка IEnumerable
            foreach (var val in list)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            list.AppendFirst(55);
            
            foreach (var val in list)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            list.Remove(55);
            list.Remove(6);

            foreach (var val in list)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
