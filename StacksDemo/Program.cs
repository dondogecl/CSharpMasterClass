using System;
using System.Collections.Generic;

namespace StacksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacks can store any type of object, but
            // of only one type per stack. Because it is a
            // Generic Collection

            // definition of a new stack
            Stack<int> stack = new Stack<int>();
            
            // add elements
            stack.Push(1);
            stack.Push(1313);
            stack.Push(301);
            stack.Push(714);

            // Take a look at the top value (read-only): Peek
            Console.WriteLine("Top value is: " + stack.Peek() );

            stack.Push(188);
            Console.WriteLine("Top value is: " + stack.Peek() );

            // Remove an element Pop()
            while (stack.Count > 0)
            {
                int returnedItem = stack.Pop();
                Console.WriteLine("Pop() value is: " + returnedItem);
                
            }

            // reverse the order of array
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> numbersStack = new Stack<int>();

            Console.WriteLine("numbers of the array: ");
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
                numbersStack.Push(number);
            }

            Console.WriteLine("Numbers taken from the Stack are in reverse");
            while(numbersStack.Count > 0)
            {
                int number = numbersStack.Pop();
                Console.Write(number + " ");
            }
        }
    }
}
