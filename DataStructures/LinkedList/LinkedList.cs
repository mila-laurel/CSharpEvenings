using System.Collections;

namespace DataStructures.LinkedList
{
    class LinkedList<T> : IEnumerable
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
            while(tailNode.Next != null)
            {
                tailNode = tailNode.Next;
            }
            tailNode.Next = node;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}