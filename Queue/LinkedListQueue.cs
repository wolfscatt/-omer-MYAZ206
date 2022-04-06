using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.Queue.Contracts;
using System.Collections;

namespace DataStructures.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> _linkedList;
        public LinkedListQueue()
        {
            _linkedList = new DoublyLinkedList<T>();
        }
        public LinkedListQueue(IEnumerable<T> collection) :this()
        {
            foreach (var item in collection)           
                EnQueue(item);
            
        }
        public int Count => _linkedList.Count;

        public T DeQueue()
        {
            if (Count == 0)
            {
                throw new EmptyQueueException("Queue is Empty");
            }
            var temp = _linkedList.RemoveFirst();
            return temp;
        }

        public void EnQueue(T item)
        {
            _linkedList.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        public T Peek()
        {
            return Count ==0 ? default(T) : _linkedList.Head.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}