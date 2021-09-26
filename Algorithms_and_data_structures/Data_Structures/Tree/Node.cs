using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Data_Structures.Tree
{
    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        int count { get; set; }

        public Node(int _Data)
        {
            Data = _Data;
        }

        public Node()
        {
        }
    }
}
