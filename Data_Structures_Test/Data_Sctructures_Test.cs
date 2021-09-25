using Algorithms_and_data_structures.Data_Structures.List;
using Algorithms_and_data_structures.Data_Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Data_Structures.Test
{
    [TestClass]
    public class Data_sctructures_Test
    {
        [TestMethod]

        public void Test_List_Constructor_No_Exception()
        {
            List<int> list = new List<int>();     
        }

        [TestMethod]
        public void Test_List_Add_First_Value_Check_Correctly_Count()
        {
            List<int> list = new List<int>();
            list.Add(35);

            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void Test_List_Add_Values_Check_Correctly_Count()
        {
            List<int> list = new List<int>();
            list.Add(35);
            list.Add(35);
            list.Add(35);
            list.Add(35);
            list.Add(35);

            Assert.AreEqual(list.Count, 5);
        }

        [TestMethod]
        public void Test_List_After_Add_Values_Check_IsEmpty()
        {
            List<int> list = new List<int>();
            list.Add(35);

            Assert.AreEqual(list.IsEmpty, false);
        }

        [TestMethod]
        public void Test_List_Empty_Check_IsEmpty()
        {
            List<int> list = new List<int>();

            Assert.AreEqual(list.IsEmpty, true);
        }

        [TestMethod]
        public void Test_List_Remove_Last_Value_Check_Correctly_Count()
        {
            List<int> list = new List<int>();
            list.Add(35);
            list.Remove(35);

            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void Test_List_Remove_NO_Last_Value_Check_Correctly_Count()
        {
            List<int> list = new List<int>();
            list.Add(15);
            list.Add(332);
            list.Add(25);
            list.Add(35);
            list.Remove(75);

            Assert.AreEqual(list.Count, 4);
        }

        [TestMethod]
        public void Test_List_Get_Values_By_Index()
        {
            List<int> list = new List<int>();
            list.Add(15);
            list.Add(332);
            list.Add(25);
            list.Add(35);
            list.Remove(75);

            Assert.AreEqual(list.GetValueIndex(1), 332);
        }

        [TestMethod]
        public void Test_List_Function_Clear_List()
        {
            List<int> list = new List<int>();
            list.Add(15);
            list.Add(332);
            list.Add(25);
            list.Add(35);
            list.Remove(75);

            list.Clear();

            Assert.AreEqual(list.IsEmpty, true);
        }

        [TestMethod]
        public void Test_List_Append_First_Value_Count()
        {
            List<int> list = new List<int>();
            list.AppendFirst(30);

            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void Test_List_Append_First_Value_In_Empty_List()
        {
            List<int> list = new List<int>();
            list.AppendFirst(30);

            Assert.AreEqual(list.IsEmpty, false);
        }

        [TestMethod]
        public void Test_List_Append_First_Value_In_NOEmpty_List()
        {
            List<int> list = new List<int>();
            list.AppendFirst(30);
            list.AppendFirst(32);
            list.AppendFirst(34);

            Assert.AreEqual(list.IsEmpty, false);
        }

        [TestMethod]
        public void Test_List_Check_Valuse_After_Append_First()
        {
            List<int> list = new List<int>();
            list.AppendFirst(30);
            list.AppendFirst(32);
            list.AppendFirst(34);

            Assert.AreEqual(list.GetValueIndex(1), 32);
        }

        // ÒÅÑÒÛ ÑÄ Ñòåê
        [TestMethod]
        public void Test_Stack_Create_Constructor_By_Default__NO_Parameters_No_Exception()
        {
            Stack<int> stack = new Stack<int>();
        }

        [TestMethod]
        public void Test_Stack_Create_Constructor_By_Default_Parameters100_No_Exception()
        {
            Stack<int> stack = new Stack<int>(100);
        }

        [TestMethod]
        public void Test_Stack_Push_Add_item_No_Exception()
        {
            Stack<int> stack = new Stack<int>(100);
            try
            {
                stack.Push(5);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void Test_Stack_Push_Add_item_Check_No_Empty()
        {
            Stack<int> stack = new Stack<int>(100);
            stack.Push(10);
            Assert.AreEqual(stack.Empty(), false);
        }

        [TestMethod]
        public void Test_Stack_Push_Add_item_Check_Count_Elements()
        {
            Stack<int> stack = new Stack<int>(100);
            stack.Push(10);
            stack.Push(10);
            stack.Push(10);
            Assert.AreEqual(stack.Count, 3);
        }

        [TestMethod]
        public void Test_Stack_Top_Get_Value_After_Add_item()
        {
            Stack<int> stack = new Stack<int>(100);
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            Assert.AreEqual(stack.Top(), 12);
        }

        [TestMethod]
        public void Test_Stack_Top_Add_item_Check_Count_Elements_After_Call_Function()
        {
            Stack<int> stack = new Stack<int>(100);
            stack.Push(10);
            stack.Push(10);
            stack.Push(10);
            stack.Top();
            Assert.AreEqual(stack.Count, 3);
        }

        [TestMethod]
        public void Test_Stack_Pop_Delete_item_And_Get_value()
        {
            Stack<int> stack = new Stack<int>(100);
            stack.Push(15);
            stack.Push(20);
            stack.Push(25);
            Assert.AreEqual(stack.Pop(), 25);
        }

        [TestMethod]
        public void Test_Stack_Pop_Delete_item_Check_Count_Elements()
        {
            Stack<int> stack = new Stack<int>(100);
            stack.Push(10);
            stack.Push(10);
            stack.Push(10);
            stack.Pop();
            Assert.AreEqual(stack.Count, 2);
        }
    }
}
