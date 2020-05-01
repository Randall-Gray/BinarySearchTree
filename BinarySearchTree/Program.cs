using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();

            for (int i = 0; i <= 10; i++)
            {
                BST.Add(i);
                BST.Add(i + 1);
                BST.Add(i - 1);
            }

            for (int i = 100; i > 0; i--)
                if (BST.Search(i))
                    Console.WriteLine("Found: " + i);
                else
                    Console.WriteLine("Not Found: " + i);

            Console.ReadLine();
        }
    }
}
