using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack & Queue!");
            StackListNode<int> stackListNode = new StackListNode<int>();
            stackListNode.Push(56);
            stackListNode.Push(30);
            stackListNode.Push(70);
            stackListNode.Show();
            stackListNode.Pop();
            stackListNode.Show();
            stackListNode.Peek();
            stackListNode.Show();
            Console.WriteLine("----------------------------------------");
            QueueListNode<int> queueListNode = new QueueListNode<int>();
            queueListNode.Enqueue(56);
            queueListNode.Enqueue(30);
            queueListNode.Enqueue(70);
            Console.WriteLine(queueListNode.Size);
            queueListNode.Dequeue();
            Console.WriteLine(queueListNode.Size);
            Console.WriteLine("----------------------------------------");

        }
    }
}
