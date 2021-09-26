using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Data_Structures.Tree
{
    public class BinaryTree
    {
        private int data;
        private int count;
        private BinaryTree left;
        private BinaryTree right;

        public BinaryTree(int _root)
        {
            data = _root;
        }

        public BinaryTree()
        {

        }

        public void Add(int item)
        {
            if (data == 0 && left == null && right == null)
            {
                data = item;
            }
            else
            {
                if (data.CompareTo(item) == 1)
                {
                    if (left == null)
                        left = new BinaryTree();
                    left.Add(item);
                }
                else if (data.CompareTo(item) == -1)
                {
                    if (right == null)
                        right = new BinaryTree();
                    right.Add(item);
                }
                else count++;
            }
        }

        public int GetMin()
        {
            BinaryTree copy = this;
            while (copy.left != null)
            {
                copy = copy.left;
            }
            return copy.data;
        }

        public int GetMax()
        {
            BinaryTree copy = this;
            while (copy.right != null)
            {
                copy = copy.right;
            }
            return copy.data;
        }

        //public bool IsFind(BinaryTree tmp, int _find)
        //{
        //    if (tmp != null)
        //    {
        //        if(tmp.data == _find)
        //            return true;
        //        IsFind(tmp.right, _find);
        //        IsFind(tmp.left, _find);
        //        return false;
        //    }
        //    return false;
        //}

        public void Print(BinaryTree tmp)
        {
            if (tmp != null)
            {
                Console.WriteLine(tmp.data);
                Print(tmp.right);
                Print(tmp.left);
            }
        }
    }
}
