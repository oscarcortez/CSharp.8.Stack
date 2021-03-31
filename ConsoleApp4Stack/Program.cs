using System;
using System.Collections.Generic;

namespace ConsoleApp4Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            numbers.Pop();
            Console.WriteLine(numbers.Peek());
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number}");
            }

            
        }
    }
}
