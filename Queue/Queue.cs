using DataStructures.Queue.Contracts;
using System.Collections;

namespace DataStructures.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private readonly IQueue<T> _queue;
        public Queue(QueueType type = QueueType.LinkedListQueue)
        {
            switch (type)
            {
                case QueueType.LinkedListQueue:
                    _queue = new LinkedListQueue<T>();
                    break;
                case QueueType.ArrayQueue:
                    _queue = new ArrayQueue<T>();
                    break;
                default:
                    throw new Exception("Unsupported Queue Type!");
            }
        }
        public int Count => _queue.Count;

        public T DeQueue()
        {
            return _queue.DeQueue();
        }

        public void EnQueue(T item)
        {
            _queue.EnQueue(item);
        }

        public T Peek()
        {
            return _queue.Peek();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}