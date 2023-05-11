using System;
using System.Collections.Generic;
namespace Generic_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // push integer values on stack.
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(9);
            myStack.Push(6);
            myStack.Push(8);
            // push string values on stack.
            Stack<string> myStack2 = new Stack<string>();
            myStack2.Push("priyanka");
            myStack2.Push("Anjali");
            myStack2.Push("Rucha");
            myStack2.Push("Nikita");
            myStack2.Push("Ashiyana");
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count); // prints 2
            Console.WriteLine("Number of elements in Stack2: {0}", myStack2.Count); // prints 2
                                                                                    // it checks whether stack is empty or not.
            if (myStack.Count > 0 && myStack2.Count > 0)
            {
                Console.WriteLine(" Not empty");
            }
            else
                Console.WriteLine("Empty");
            // printing values of stack
            Console.WriteLine("Integer Values of Stack:");
            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("String Values of Stack:");
            foreach (string item1 in myStack2)
            {
                Console.WriteLine(item1);
            }
            // Pop Values of stack
            Console.WriteLine($"\nPop integer element:{myStack.Pop()}");
            //printing value after pop operation
            Console.WriteLine("All Stack Elements After Pop:");
            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nPop String element:{myStack2.Pop()}");
            //printing value after pop operation
            Console.WriteLine("All Stack Elements After Pop:");
            foreach (string item in myStack2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}