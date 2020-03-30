using System;

public class Node
{
    public string data;
    public Node left;
    public Node right;

    public Node(string value)
    {
        data = value;
        left = null;
        right = null;
    }

    public bool isLeaf(ref Node node)
    {
        return (node.left == null && node.right == null);
    }

    public void insertData(ref Node node, string input)
    {
        if (node == null)
        {
            node = new Node(input);
        }
        else
        {
            if(node.left == null)
            {
                insertData(ref node.left, input);
            }
            else
            {
                insertData(ref node.right, input);
            }
        }
    }

    public void display(Node n)
    {
        if(n == null)
        {
            return;
        }

        display(n.left);
        Console.Write(" " + n.data);
        display(n.right);
    }
}

public class BinaryTree
{
    private Node root;
    private int count;

    public BinaryTree()
    {
        root = null;
        count = 0;
    }

    public bool isEmpty()
    {
        return root == null;
    }

    public void insert(string input)
    {
        if(isEmpty())
        {
            root = new Node(input);
        }
        else
        {
            root.insertData(ref root, input); 
        }

        count++;
    }

    public bool isLeaf()
    {
        if(!isEmpty())
        {
            return root.isLeaf(ref root);
        }

        return true;
    }

    public void display()
    {
        if(!isEmpty())
        {
            root.display(root);
        }
    }

    public int Count()
    {
        return count;
    }
}