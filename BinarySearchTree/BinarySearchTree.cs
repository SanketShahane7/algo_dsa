using System;

namespace algo_dsa.BinarySearchTree;

public class BinarySearchTree
{
    public TreeNode Root { get; set; }

    public BinarySearchTree()
    {
        this.Root = null;
    }

    // public void Insert(int key, string value)
    // {
    //     TreeNode newNode = new TreeNode(key, value);
    //     if (Root == null)
    //     {
    //         Root = newNode;
    //         return;
    //     }

    //     TreeNode current = Root;
    //     TreeNode parent = null;

    //     while (true)
    //     {
    //         parent = current;
    //         if (key < current.key)
    //         {
    //             current = current.LeftChild;
    //             if (current == null)
    //             {
    //                 parent.LeftChild = newNode;
    //                 return;
    //             }
    //         }
    //         else
    //         {
    //             current = current.RightChild;
    //             if (current == null)
    //             {
    //                 parent.RightChild = newNode;
    //                 return;
    //             }
    //         }
    //     }
    // }
    public void Insert(int key, string value)
    {
        Root = InsertItem(Root, key, value);
    }

    public TreeNode InsertItem(TreeNode node, int key, string value)
    {
        TreeNode treeNode = new TreeNode(key, value);

        //-- If this is the first time you Insert, Create the root node
        if (node == null)
        {
            node = treeNode;
            return node;
        }

        //-- IF this is not the first time you insert, traverse, find NULL, Insert 
        if (key < node.Key)
            node.LeftChild = InsertItem(node.LeftChild, key, value);
        else
            node.RightChild = InsertItem(node.RightChild, key, value);

        return node;
    }

    public TreeNode Search(int key)
    {
        TreeNode current = Root;

        while (current != null && current.Key != key)
        {
            if (key < current.Key)
            {
                current = current.LeftChild;
            }
            else
            {
                current = current.RightChild;
            }
        }

        return current; // Will be null if not found
    }

}
