using Algorithms_and_data_structures.Data_Structures.List;
using Algorithms_and_data_structures.Data_Structures;
using System;

namespace Algorithms_and_data_structures
{
    class Program
    {
        private static void TestList()
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

            Console.WriteLine(list.GetValueIndex(1));
        }

        private static void TestStack()
        {
            Stack<int> stack = new Stack<int>(2);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            //stack.Pop();
            //stack.Pop();

            foreach(var val in stack)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Верхушка - " + stack.Top());
        }

        static void Main(string[] args)
        {
            //TestList();
              TestStack();
        }
    }
}
