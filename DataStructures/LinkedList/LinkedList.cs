using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        public ListNode<T> Head { get; private set; }
        
        public void Add(T element)
        {
            ListNode<T> node = new ListNode<T>(element, Head);
            Head = node;
        }

        public void AddTail(T element)
        {
            ListNode<T> node = new ListNode<T>(element);
            if (Head == null)
            {
                Head = node;
                return;
            }

            ListNode<T> tailNode = Head;
            while (tailNode.Next != null)
            {
                tailNode = tailNode.Next;
            }
            tailNode.Next = node;
        }
                
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }
    }
}