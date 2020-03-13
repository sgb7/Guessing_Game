using System;

public class Node
{
    public string data;
    public Node left, right;

    public Node(string info)
    {
        data = info;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;

    BinaryTree(string info)
    {
        root = new Node(info);
    }

    BinaryTree()
    {
        root = null;
    }
}