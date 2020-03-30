using System;

namespace BinaryTreeProject
{
    public class Node
    {
        public string data;
        public Node leftChild;
        public Node rightChild;

        public Node(string value)
        {
            data = value;
            leftChild = null;
            rightChild = null;
        }

        public bool isLeaf(ref Node node)
        {
            return (node.leftChild == null && node.rightChild == null);
        }

        public void insertData(ref Node node, string input, string input2)
        {
            
            if (node == null)
            {
                node = new Node(input);
            }
            else
            {
                if (input2 == "no")
                {
                    insertData(ref node.leftChild, input, input2);
                }
                else if (input2 == "yes")
                {
                    insertData(ref node.rightChild, input, input2);
                }
                else
                {
                    Console.WriteLine("This is an invalid response. Please answer yes or no.");
                }
            }
        }

        public void display(Node n)
        {
            if (n == null)
            {
                return;
            }

            display(n.leftChild);
            Console.Write(" " + n.data);
            display(n.rightChild);
        }
    }

    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public bool isEmpty()
        {
            return root == null;
        }

        public void insert(string input, string input2)
        {
            if (isEmpty())
            {
                root = new Node(input);
            }
            else
            {
                root.insertData(ref root, input, input2);
            }
        }

        public bool isLeaf()
        {
            if (!isEmpty())
            {
                return root.isLeaf(ref root);
            }

            return true;
        }

        public void display()
        {
            if (!isEmpty())
            {
                root.display(root);
            }
        }
    }
}