using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree TheTree = new Tree(); // Instance of the tree

            TheTree.Add(1); // Add to the tree the following elements
            TheTree.Add(2);
            TheTree.Add(7);
            TheTree.Add(3);
            TheTree.Add(10);
            TheTree.Add(5);
            TheTree.Add(8);
            TheTree.Add(88);
            TheTree.Add(888);
            Node node = TheTree.Find(5);
            int depth = TheTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            TheTree.TraversePreOrder(TheTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            TheTree.TraverseInOrder(TheTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            TheTree.TraversePostOrder(TheTree.Root);
            Console.WriteLine();

            TheTree.Remove(7);
            TheTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            TheTree.TraversePreOrder(TheTree.Root);
            Console.WriteLine(" ");
            Console.WriteLine("Depht");
            Console.WriteLine(depth);

            Console.WriteLine(" ");
            Console.WriteLine("1");
            Console.WriteLine("  |");
            Console.WriteLine("  2");
            Console.WriteLine("    |");
            Console.WriteLine("    7");
            Console.WriteLine("   |   |");
            Console.WriteLine("   3   10");
            Console.WriteLine("    |  |");
            Console.WriteLine("    5  8");
            Console.ReadLine();
        }
    }
}
