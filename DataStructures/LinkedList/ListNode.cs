namespace DataStructures.LinkedList
{
    class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data, ListNode<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }
}