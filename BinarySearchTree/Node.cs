using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        // Member variables
        T data;

        Node<T> leftChild;
        Node<T> rightChild;
    }
}
