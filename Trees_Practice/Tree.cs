using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Practice
{
    internal class Tree
    {
        public Node Root { get; set; } // Begins in Null

        public bool Add(int value) // Add method
        {
            Node before = null, after = this.Root;

            while (after != null) // Is after a null value?
            {
                before = after;
                if (value < after.Data) // If the value is less than after the node goes to the left? 
                    after = after.LeftNode; // After converts to the left node son
                else if (value > after.Data) //If the value is greater than after the node goes to the right?
                    after = after.RightNode; // After converts to the the right node son
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node(); // Create an instance to a new node
            newNode.Data = value; // Give the value to the Data of the new node

            if (this.Root == null)// Root is empty
                this.Root = newNode; // Give newnode to Root
            else
            {
                if (value < before.Data) // If the value is less than before the data goes to left
                    before.LeftNode = newNode;
                else // If the value is less than before the data goes to right
                    before.RightNode = newNode;
            }

            return true;
        }

        public Node Find(int value)
        {
            return this.Find(value, this.Root); // Put the value to find and the root of the tree
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent; // If the value is equal to the parent data, this data will be returned
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }

        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}
