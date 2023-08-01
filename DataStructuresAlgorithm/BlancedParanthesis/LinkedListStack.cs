using DataStructureAlgorithm.UnOrderedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.BlancedParanthesis
{
    public class LinkedListStack<T>
    {
        private Node<T> top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            
        }
        internal void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                return;
            }
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                return;
            }
            this.top = this.top.next;
        }
        internal bool IsEmpty()
        {
            if (this.top == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
