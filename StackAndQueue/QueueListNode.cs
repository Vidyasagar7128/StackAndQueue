using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class QueueListNode<Gtype>
    {
        Node<Gtype> forword;
        Node<Gtype> backword;
        int size;

        public QueueListNode()
        {
            this.forword = null;
            this.backword = null;
            size = 0;
        }
        internal void Enqueue(int val)
        {
            Node<Gtype> node = new Node<Gtype>(val);
            if (this.backword == null)
            {
                this.forword = node;
                this.backword = node;
            }
            else
            {
                this.backword.Next = node;
                this.forword = node;
            }
            Console.WriteLine(val);
            size++;
        }
        internal void Dequeue()
        {
            if (this.forword == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node<Gtype> temp = this.forword;
            this.forword = this.forword.Next;

            if (this.forword == null)
                this.backword = null;

            Console.WriteLine("Item deleted is {0}", temp.Data);
            size--;
        }
        public int Size
        {
            get { return size; }
        }
    }
}
