using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algo_dsa.Queue;

public class Queue
{
    public int MaxSize { get; set; }        //-- Sets the number of elements the queue can hold
    public string[] QueueArray { get; set; }    //-- Actual array to hold the queue elements
    public int Front { get; set; }  //-- Index to keep track of the front element
    public int Rear { get; set; }   //-- Index to keep track of the rear element
    public int CurrentSize { get; set; }    //-- Current number of elements in the queue

    public Queue(int size)
    {
        this.MaxSize = size;
        this.QueueArray = new string[this.MaxSize];
        this.Front = 0;
        this.Rear = -1;
        this.CurrentSize = 0;
    }

    public void Enqueue(string item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full. Cannot enqueue new element.");
            return;
        }

        this.Rear = (this.Rear + 1) % this.MaxSize;
        this.QueueArray[this.Rear] = item;
        this.CurrentSize++;
        Console.WriteLine($"Enqueued {item} to queue.");
    }

    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot dequeue element.");
            return null;
        }

        string item = this.QueueArray[this.Front];
        this.QueueArray[this.Front] = null; // Clear the reference
        this.Front = (this.Front + 1) % this.MaxSize;
        this.CurrentSize--;
        Console.WriteLine($"Dequeued {item} from queue.");
        return item;
    }

    public string Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot peek element.");
            return null;
        }

        return this.QueueArray[this.Front];
    }

    public bool IsEmpty()
    {
        return this.CurrentSize == 0;
    }    
    public bool IsFull()
    {
        return this.CurrentSize == this.MaxSize;
    }
}
