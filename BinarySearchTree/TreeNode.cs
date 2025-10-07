using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algo_dsa.BinarySearchTree;

public class TreeNode
{
    public int Key { get; set; }
    public string Value { get; set; }
    public TreeNode LeftChild { get; set; }
    public TreeNode RightChild { get; set; }

    public TreeNode(int key, string value)
    {
        this.Key = key;
        this.Value = value;
        this.LeftChild = null;
        this.RightChild = null;
    }
}