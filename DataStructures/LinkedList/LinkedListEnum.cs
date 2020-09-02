using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class LinkedListEnum : IEnumerator
    {
        public LinkedList<int> _list;

        ListNode<int> previousNode;
        ListNode<int> nodePosition;
        public LinkedListEnum(LinkedList<int> linkedList)
        {
            _list = linkedList;
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            ListNode<int> previousNode = _list.Head;
            nodePosition = previousNode.Next;
            return (nodePosition != null);
        }

        public void Reset()
        {
            nodePosition = previousNode;
        }

        public ListNode <int> Current
        {
            get
            {
                try
                {
                    return nodePosition;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }

        }
    }
}
