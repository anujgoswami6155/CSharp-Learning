using System;
using System.Collections.Generic;

Console.Title = "Collections Demonstration";

Console.WriteLine("===============================================");
Console.WriteLine("        C# COLLECTIONS DEMONSTRATION");
Console.WriteLine("===============================================\n");


// ======================================================
// LIST
// ======================================================
Console.WriteLine("1. LIST COLLECTION");
Console.WriteLine("------------------------------");

List<int> list = new List<int> { 2, 30, 14, 8, 21, 8 };

Console.WriteLine("Values stored in the List:");

foreach (int num in list)
{
    Console.Write(num + " ");
}

Console.WriteLine("\n");
Console.WriteLine("Observation:");
Console.WriteLine("- List stores elements in insertion order.");
Console.WriteLine("- Duplicate values are allowed.");
Console.WriteLine("- Elements can be accessed using an index.");

Console.WriteLine("\n===============================================\n");


// ======================================================
// STACK
// ======================================================
Console.WriteLine("2. STACK COLLECTION");
Console.WriteLine("------------------------------");

Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);

Console.WriteLine("Values stored in the Stack:");

foreach (int num in stack)
{
    Console.Write(num + " ");
}

Console.WriteLine("\n");
Console.WriteLine("Top element (Peek): " + stack.Peek());

Console.WriteLine("\nObservation:");
Console.WriteLine("- Stack follows LIFO (Last In, First Out).");
Console.WriteLine("- The last inserted element is retrieved first.");

Console.WriteLine("\n===============================================\n");


// ======================================================
// QUEUE
// ======================================================
Console.WriteLine("3. QUEUE COLLECTION");
Console.WriteLine("------------------------------");

Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);

Console.WriteLine("Values stored in the Queue:");

foreach (int num in queue)
{
    Console.Write(num + " ");
}

Console.WriteLine("\n");
Console.WriteLine("Front element (Peek): " + queue.Peek());

Console.WriteLine("\nObservation:");
Console.WriteLine("- Queue follows FIFO (First In, First Out).");
Console.WriteLine("- The first inserted element is retrieved first.");

Console.WriteLine("\n===============================================\n");


// ======================================================
// DICTIONARY
// ======================================================
Console.WriteLine("4. DICTIONARY COLLECTION");
Console.WriteLine("------------------------------");

Dictionary<int, string> dictionary = new Dictionary<int, string>()
{
    {101, "A"},
    {102, "B"},
    {103, "C"},
    {104, "D"},
    {105, "E"}
};

Console.WriteLine("Dictionary Contents:");
Console.WriteLine("Key\tValue");

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine($"{item.Key}\t{item.Value}");
}

Console.WriteLine("\nObservation:");
Console.WriteLine("- Dictionary stores data as Key-Value pairs.");
Console.WriteLine("- Each key must be unique.");
Console.WriteLine("- Values are accessed using their corresponding keys.");

Console.WriteLine("\n===============================================");
Console.WriteLine("         DEMONSTRATION COMPLETED");
Console.WriteLine("===============================================");

Console.ReadKey();
