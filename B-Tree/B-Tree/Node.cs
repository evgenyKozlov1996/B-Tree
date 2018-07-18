using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Tree
{
    /// <summary>
    /// Represents node of binary tree
    /// </summary>
    public class Node
    {
        //Weight of the node
        public int Weight { get; set; }

        //Lins to the left and right nodes of binary search tree
        public Node Left;
        public Node Right;

    }
}
