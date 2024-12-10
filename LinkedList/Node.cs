using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }
}
