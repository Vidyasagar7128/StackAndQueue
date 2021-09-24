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
