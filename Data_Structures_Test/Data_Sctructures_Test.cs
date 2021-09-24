using Algorithms_and_data_structures.Data_Structures.List;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Data_Structures.Test
{
    [TestClass]
    public class Data_sctructures_Test
    {
        [TestMethod]

        public void Test_List_Constructor()
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
    }
}
