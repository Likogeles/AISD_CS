using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class BinTree
{

    struct Node
    {
        int data;
        Node* big;
        Node* small;

        Node(int val)
        {
            data = val;
            big = null;
            big = null;
        }
    }

    public BinTree()
    {
    }
}
