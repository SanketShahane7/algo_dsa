using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algo_dsa.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}