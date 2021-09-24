using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack & Queue!");
            StackListNode<int> stackListNode = new StackListNode<int>();
            stackListNode.Push(70);
            stackListNode.Push(30);
            stackListNode.Push(56);
            stackListNode.Show();
        }
    }
}
