using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class StackListNode<Gtype>
    {
        private Node<Gtype> top;
        public StackListNode()
        {
            this.top = null;

        }
        internal void Push(int d)
        {
            Node<Gtype> node = new Node<Gtype>(d);
            if (this.top == null)
                node.Next = null;
            else
                node.Next = this.top;
            this.top = node;
            Console.WriteLine($"data : {d}");
        }
        internal void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty!");
                return;
            }
            Console.WriteLine("{0} top of Stack",this.top.Data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty! Delettion is not Possible.");
                return;
            }
            Console.WriteLine("Values Popped is : {0}", this.top.Data);
            this.top = this.top.Next;
        }
        internal void IsEmpty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
        }
        internal void Show()
        {
            Node<Gtype> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine($"{temp.Data} ");
                temp = temp.Next;
            }
        }
    }
}
