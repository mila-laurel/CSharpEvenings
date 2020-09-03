using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    struct LinkedListEnumerator<T> : IEnumerator<T>
    {
        private readonly LinkedList<T> _list;

        ListNode<T> currentNode;
        
        public T Current => currentNode.Data;

        object IEnumerator.Current => Current;

        public LinkedListEnumerator(LinkedList<T> linkedList)
        {
            _list = linkedList;
            currentNode = null;
        }

        public bool MoveNext()
        {
            if(currentNode == null)
                currentNode = _list.Head;
            else
                currentNode = currentNode.Next;

            return (currentNode != null);
        }

        public void Reset()
        {
            currentNode = null;
        }
 
        public void Dispose()
        {
           currentNode = null;
        }       
    }
}
