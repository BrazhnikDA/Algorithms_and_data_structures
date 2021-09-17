using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures.Sorts
{
    internal class InputData
    {
        public static IList<int> CreateData(int size)
        {
            Random rnd = new Random();
            IList<int> list = new List<int>();

            for(int i = 0; i < size; i++)
            {
                list.Add(rnd.Next(0, 100));
            }

            return list;
        }
    }
}
