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

        public BinaryTree DeleteNode(int deleteData, BinaryTree root)
        {
            if (root == null)
                return root;
            if (deleteData < root.data)
            {
                root.left = DeleteNode(deleteData, root.left);
            }
            else if (deleteData > root.data)
            {
                root.right = DeleteNode(deleteData, root.right);
            }
            else if (root.left != null && root.right != null)
            {
                root.data = GetMin();
                root.right = DeleteNode(root.data, root.right);
            }
            else if (root.left != null)
            {
                return root.left;
            }
            else
            {
                return root.right;
            }

            return root;

        }

        public bool IsFind(BinaryTree tmp, int find)
        {
            bool IsEntry;
            while (true)
            {
                IsEntry = false;
                if (tmp.data == find)
                    return true;
                while (find > tmp.data)
                {
                    IsEntry = true;
                    if (tmp.right != null)
                    {
                        tmp = tmp.right;
                        if (tmp.data == find)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        IsEntry = false;
                        break;
                    }
                }
                while (find < tmp.data)
                {
                    IsEntry = true;
                    if (tmp.left != null)
                    {
                        tmp = tmp.left;
                        if (tmp.data == find)
                        {
                            return true;
                        }
                    }else
                    {
                        IsEntry = false;
                        break;
                    }
                }
                if(IsEntry == false)
                {
                    return false;
                }
            }
        }

        public void Clear()
        {
            data  = 0;
            count = 0;
            left  = null;
            right = null;
        }

        public bool IsEmpty()
        {
            if (this == null)
                return true;
            else
                return false;
        }

        public void Print(BinaryTree tmp)
        {
            if (tmp != null)
            {
                Console.Write("root: " + tmp.data);
                //Console.Write("L: ");
                Print(tmp.right);
                //Console.Write("R: ");
                Print(tmp.left);
            }
        }

        public void Print(int x, int y, BinaryTree root, int delta = 0) // Указатель курсора по x и y
        {
            if (root != null)
            {
                if (delta == 0) delta = x / 2;
                Console.SetCursorPosition(x, y);
                Console.Write(root.data);
                Print(x - delta, y + 3, root.left, delta / 2);
                Print(x + delta, y + 3, root.right, delta / 2);
            }

        }
    }
}
