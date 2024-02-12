namespace ChatQueue
{
    public class TQueue<T> where T : class, new()
    {
        private T?[] _queue;
        private int front = 0, back = -1; 
        private readonly int _capacity;

        public TQueue(int capacity)
        {
            _capacity = capacity;
            _queue = new T?[_capacity];
        }

        public bool IsFull => back == _capacity - 1; 

        public bool IsEmpty => front > back; 

        public void Enqueue(T? item)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Queue is full");
            }
            back++; 
            _queue[back] = item; 
        }

        public T? Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T? item = _queue[front];
            _queue[front] = null; 
            front++; 
            return item;
        }
    }
}
