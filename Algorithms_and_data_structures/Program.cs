using Algorithms_and_data_structures.Data_Structures.List;
using Algorithms_and_data_structures.Data_Structures;   
using Algorithms_and_data_structures.Data_Structures.Queue;
using Algorithms_and_data_structures.Data_Structures.Tree;
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
            Console.Write("Элементы списка - ");
            foreach (var val in list)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            list.AppendFirst(55);

            Console.Write("Вставка в начало 55 - ");
            foreach (var val in list)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            list.Remove(55);
            list.Remove(6);

            Console.Write("После удаления элементов 55 и 6 - ");
            foreach (var val in list)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            Console.Write("Значение по индексу 1 - ");
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

        private static void TestQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();
            queue.Dequeue();

            foreach (var val in queue)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Первый элемент - " + queue.First);
        }

        private static void TestBinaryTree()
        {
            BinaryTree tree = new BinaryTree(8);
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);
            tree.Add(14);
            tree.Add(6);
            tree.Add(4);
            tree.Add(7); 
            tree.Add(13);
            tree.Add(20);
            tree.Add(30);
            tree.Add(40);

            Console.WriteLine("Min - {0}", tree.GetMin());
            Console.WriteLine("Max - {0}", tree.GetMax());

            Console.WriteLine("Find - 6 = {0}", tree.IsFind(tree, 6));
            Console.WriteLine("Find - 11 = {0}", tree.IsFind(tree, 11));
            Console.WriteLine("Find - 1 = {0}", tree.IsFind(tree, 1));
            Console.WriteLine("Find - 13 = {0}", tree.IsFind(tree, 13));
            Console.WriteLine("Find - 55 = {0}", tree.IsFind(tree, 55));
            Console.WriteLine("Find - 100 = {0}", tree.IsFind(tree, 100));
            Console.WriteLine("Find - 0 = {0}", tree.IsFind(tree, 0));
            Console.WriteLine("Find - 14 = {0}", tree.IsFind(tree, 14));

            tree.Print(tree);
            tree.DeleteNode(30, tree);
            Console.WriteLine();
            tree.Print(tree);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Список:");
            //TestList();

            //Console.WriteLine("\nСтек:");
            //TestStack();

            //Console.WriteLine("\nОчередь:");
            //TestQueue();

            TestBinaryTree();
        }
    }
}
