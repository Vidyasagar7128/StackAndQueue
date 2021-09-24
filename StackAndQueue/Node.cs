using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Node<Gtype>
    {
        private int data;
        private Node<Gtype> next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public Node<Gtype> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}