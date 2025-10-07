using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algo_dsa.LinkedList
{
    public class LinkedList
    {
        public Node? Head { get; set; }

        public void InsertFirst(int data)
        {
            // Create a new node
            Node newNode = new Node();

            // Assign data to the new node
            newNode.Data = data;

            // Put the old node in next
            newNode.Next = Head;

            // Move the head to point to new node
            Head = newNode;
        }

        public Node DeleteFirst()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty. Cannot delete.");
                return null;
            }

            // Store the head node temporarily
            Node temp = Head;

            // Update the head
            Head = Head.Next;

            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through the list:");
            Node? current = Head;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
}