using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms_and_data_structures;
using Algorithms_and_data_structures.Sorts;

namespace Algorithms_and_data_structures.Tests
{
    [TestClass]
    public class SortingTests
    {
        private const int size = 500;

        [TestMethod]
        public void Checked_Bubble_Sorting()
        {
            IList<int> list;

            list = Bubble_Sort.Sort(InputData.CreateData(size));
            
            bool IsSort = true;
            for(int i = 0; i < list.Count - 1; i++)
            {
                if(list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }

        [TestMethod]
        public void Checked_Choice_Sorting()
        {
            IList<int> list;

            list = Choise_Sort.Sort(InputData.CreateData(size));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }

        [TestMethod]
        public void Checked_Insert_Sorting()
        {
            IList<int> list;

            list = Inserts_Sort.Sort(InputData.CreateData(size));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }

        [TestMethod]
        public void Checked_Merge_Sorting()
        {
            IList<int> list;

            list = Merge_Sort.Sort(InputData.CreateData(size));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }

        [TestMethod]
        public void Checked_Quick_Sorting()
        {
            IList<int> list;

            list = Quick_Sort.Sort(InputData.CreateData(size));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }

        [TestMethod]
        public void Checked_MultithreadingQuick_Sorting_Even()
        {
            IList<int> list;

            list = Multithreading_Quick_Sort.Sort(InputData.CreateData(500));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }

        [TestMethod]
        public void Checked_MultithreadingQuick_Sorting_Odd()
        {
            IList<int> list;

            list = Multithreading_Quick_Sort.Sort(InputData.CreateData(823));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }


        [TestMethod]
        public void Checked_Shell_Sorting()
        {
            IList<int> list;

            list = Shell_Sort.Sort(InputData.CreateData(size));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }

        [TestMethod]
        public void Checked_Dwarf_Sorting()
        {
            IList<int> list;

            list = Dwarf_Sort.Sort(InputData.CreateData(size));

            bool IsSort = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1]) { IsSort = false; break; }
            }

            Assert.AreEqual(true, IsSort);
        }
    }
}
