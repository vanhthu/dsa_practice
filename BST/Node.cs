using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Node
    {
        public int key;
        public Node left;
        public Node right;

        public Node()
        {
            left = null;
            right = null;
        }

        public Node(int aKey)
        {
            key = aKey;
            left = null;
            right = null;            
        }
    }
}
