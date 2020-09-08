using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        public ListNode<T> Head { get; private set; }

        public LinkedList(ListNode<T> head = null)
            {
            Head = head;
            }
        public T this[int i]
        {
            get
            {
                return FindNodeByIndex(i).Data;
            }
            set
            {
                var node = FindNodeByIndex(i);
                node.Data = value;
            }
        }

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

        public void Remove(T element)
        {
            if (Head == null)
                return;

            if (Head.Data.Equals(element))
            {
                Head = Head.Next;
                return;
            }
                
            RemoveValue(Head, Head.Next, element);
        }

        private void RemoveValue(ListNode<T> parentNode, ListNode<T> currentNode, T element)
        {
            if(currentNode == null)
                return;

            if(currentNode.Data.Equals(element))
            {
                parentNode.Next = currentNode.Next;
                return;
            }

            RemoveValue(currentNode, currentNode.Next, element);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }

        private ListNode<T> FindNodeByIndex(int index)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Index has to be non negative");

            var current = Head;
            while (current != null && index > 0)
            {
                current = current.Next;
                index--;
            }

            if (current == null)
                throw new IndexOutOfRangeException();

            return current;
        }
    }
}