// See https://aka.ms/new-console-template for more information
using algo_dsa.BinarySearch;
using algo_dsa.BinarySearchTree;
using algo_dsa.BubbleSort;
using algo_dsa.LinkedList;
using algo_dsa.Queue;
using algo_dsa.Stacks;
using algo_dsa.Array.Duplicates;

Console.WriteLine("Hello, World!");


#region Linked List Implementation

// Node nodeA = new Node();
// nodeA.Data = 10;

// Node nodeB = new Node();
// nodeB.Data = 20;

// Node nodeC = new Node();
// nodeC.Data = 30;

// nodeA.Next = nodeB;
// nodeB.Next = nodeC;


// LinkedList linkedList = new LinkedList();
// linkedList.InsertFirst(10);
// linkedList.InsertFirst(20);
// linkedList.InsertFirst(30);

// linkedList.InsertLast(5);
// linkedList.DisplayList(); // Should display 30, 20, 10, 5

// linkedList.DeleteFirst();
// linkedList.DisplayList(); // Should display 20, 10, 5

// linkedList.DeleteFirst();
// linkedList.DisplayList(); // Should display 10, 5

// linkedList.DeleteFirst();
// linkedList.DisplayList(); // Should display 5

// linkedList.DeleteFirst();
// linkedList.DisplayList(); // Should display "List is empty"

// linkedList.DeleteFirst(); // Should display "List is empty. Cannot delete."

#endregion


#region Stack Implementation

// Stack stack = new Stack(10);

// for(int i = 0; i < 10; i++)
// {
//     stack.Push($"Item {i+1}");
// }

// Console.WriteLine($"Top item is: {stack.Peek()}");

// stack.Pop();
// Console.WriteLine($"Top item is: {stack.Peek()}");

// while(!stack.IsEmpty())
// {
//     stack.Pop();
// }

// stack.Pop(); // Should display "Stack is empty. Cannot pop element."


#endregion


#region Queue Implementation

// Queue queue = new Queue(5);
// for (int i = 0; i < 5; i++)
// {
//     queue.Enqueue($"Item {i + 1}");
// }

// queue.Dequeue();
// queue.Dequeue();

// Console.WriteLine($"Top item is: {queue.Peek()}");

#endregion


#region Binary Search Implementation

// int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// BinarySearch binarySearch = new BinarySearch(arr);
// int target = 4;
// int index = binarySearch.Search(target);
// if (index != -1)
// {
//     Console.WriteLine($"Target {target} found at index: {index}");
// }
// else
// {
//     Console.WriteLine($"Target {target} not found in the array.");
// }

#endregion


#region Binary Search Tree Implementation

// BinarySearchTree bst = new BinarySearchTree();
// bst.Insert(7, "Squirtle");
// bst.Insert(3, "Eknas");
// bst.Insert(151, "Mew");
// bst.Insert(4, "Charmander");
// bst.Insert(1, "Bulbasaur");
// bst.Insert(6, "Pikachu");
// bst.Insert(8, "Charizard");

// Console.WriteLine($"-- Search for 6: {bst.Search(6).Value}"); // Should find Pikachu

#endregion

#region Bubble Sort Implementation

// int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

// int[] sortedArray = BubbleSort.Sort(intArray);

// Console.WriteLine($"Sorted Array: {string.Join(", ", sortedArray)}");

#endregion 


#region Recursion Implementation (Factorial)

// PartyFunction();
// void PartyFunction()
// {
//     Console.WriteLine("PartyFunction called");
//     var value = Guid.NewGuid();
//     //-- Recursivly call itself (Call Stack will keep track of calls)
//     PartyFunction();
//     // return true;
// }


// var val = 5;
// MinusByOne(val);
// void MinusByOne(int val)
// {
//     if (val != 0)
//     {
//         Console.WriteLine($"Current value: {val}");
//         //-- Recursively call itself | All calls will be stored in Call Stack (Maintaining their Execution State)
//         MinusByOne(val - 1);
//     }
//     Console.WriteLine($"Final value: {val}");
// }

// Console.WriteLine($"End of Program: value: {val}");


//-- Factorial of a number using Recursion

//--> Ye he Aaam jindagi
// Console.WriteLine($"Factorial of 5 is: {IterativeFactorial(5)}");

// int IterativeFactorial(int n)
// {
//     int factorial = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         factorial *= i;
//     }
//     return factorial;
// }


//--> Ye he Mentos jindagi
// Console.WriteLine($"Factorial of 5 is: {RecursiveFactorial(5)}");

// int RecursiveFactorial(int n)
// {
//     if (n == 1)
//     {
//         return 1;
//     }
//     var factorial = n * RecursiveFactorial(n - 1);
//     Console.WriteLine($"Intermediate factorial for {n} is: {factorial}");
//     return factorial;
// }

#endregion


#region Duplicates in Array using Hashing

var arrayWithDuplicates = new int[] { 1, 2, 3, 2, 4, 5 };
var arrayWithoutDuplicates = new int[] { 1, 2, 3, 4, 5 };

ArrayHashingDuplicates arrayHashingDuplicates = new ArrayHashingDuplicates();
bool hasDuplicates1 = arrayHashingDuplicates.HasDuplicate(arrayWithDuplicates);
Console.WriteLine($"Array with duplicates has duplicates: {hasDuplicates1}"); // Expected:
bool hasDuplicates2 = arrayHashingDuplicates.HasDuplicate(arrayWithoutDuplicates);
Console.WriteLine($"Array without duplicates has duplicates: {hasDuplicates2}"); // Expected:

#endregion

