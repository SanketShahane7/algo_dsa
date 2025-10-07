using System;

namespace algo_dsa.Stacks;

public class Stack
{
    public int MaxSize { get; set; }
    public string[] StackArray { get; set; }
    public int Top { get; set; }

    public Stack(int size)
    {
        this.MaxSize = size;
        //-- Initialize the stack array with the given size
        this.StackArray = new string[this.MaxSize];
        //-- We give the top -1 because the array index starts from 0
        this.Top = -1;
    }

    public void Push(string item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full. Cannot push new element.");
            return;
        }

        this.StackArray[++this.Top] = item;
        Console.WriteLine($"Pushed {item} to stack.");
    }

    public string Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop element.");
            return null;
        }

        string item = this.StackArray[this.Top];
        this.StackArray[this.Top--] = null; // Clear the reference
        Console.WriteLine($"Popped {item} from stack.");
        return item;
    }
    public string Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot peek element.");
            return null;
        }

        return this.StackArray[this.Top];
    }

    public bool IsEmpty()
    {
        return this.Top == -1;
    }    
    public bool IsFull()
    {
        return this.Top == this.MaxSize - 1;
    }
}
