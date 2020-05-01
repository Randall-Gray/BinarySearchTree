using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable
    {
        // Member variables
        private Node<T> root;

        // constructor

        // Member methods
        // Add the data to the binary search tree.
        public void Add(T data)
        {
            bool added = false;

            Node<T> addNode = new Node<T>();
            addNode.data = data;

            if (root == null)
            {
                root = addNode;
                return;
            }

            Node<T> searchNode = root;

            while (!added)
            {
                if (searchNode.data.CompareTo(data) >= 0)        // go left - duplicates considered "less than"
                {
                    if (searchNode.leftChild != null)
                    {
                        searchNode = searchNode.leftChild;
                    }
                    else
                    {
                        searchNode.leftChild = addNode;
                        added = true;
                    }
                }
                else                                            // go right        
                {
                    if (searchNode.rightChild != null)
                    {
                        searchNode = searchNode.rightChild;
                    }
                    else
                    {
                        searchNode.rightChild = addNode;
                        added = true;
                    }
                }
            }
        }

        // Returns whether or not data found in binaryy search tree.
        public bool Search(T data)
        {
            bool found = false;

            Node<T> searchNode = root;

            while (searchNode != null && !found)
            {
                if (searchNode.data.Equals(data))
                    found = true;
                else if (searchNode.data.CompareTo(data) > 0)   // go left
                    searchNode = searchNode.leftChild;
                else                                            // go right 
                    searchNode = searchNode.rightChild;
            }

            return found;
        }
    }
}
