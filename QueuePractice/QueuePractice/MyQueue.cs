namespace QueuePractice
{
    class MyQueue
    {
        //Fields
        private LinkedList<int> _container = new LinkedList<int>();
        private LinkedListNode<int>? _front;
        private LinkedListNode<int>? _rear;
        private int _count;

        //Properties
        public LinkedListNode<int> Front
        {
            get { return _front; }
        }

        public LinkedListNode<int> Rear
        {
            get { return _rear; }
        }

        public int Count
        {
            get { return _count; }
        }

        // Methods
        public int Peek() // Front에 위치한 데이터를 가져옵니다.
        {
            if (_container.Count == 0)
            {
                Console.WriteLine("Queue is empty. Cannot Peek.");
                return 0;
            }

            return _front.Value;
        }

        
        public void Enqueue(int data) // Rear에 데이터를 삽입합니다.
        {
            _rear = _container.AddLast(data);

            if (_container.Count == 1)
            {
                _front = _rear;
            }

            _count++;
        }

        
        public void Dequeue() // Front에서 데이터를 제거합니다.
        {
            if (_container.Count == 0)
            {
                Console.WriteLine("Queue is empty. Cannot Dequeue.");
                return;
            }

            _container.RemoveFirst();

            _front = _container.First;

            _count--;
        }
    }

    class Test
    {
        static void Main()
        {
            MyQueue myQueue = new MyQueue();

            Console.WriteLine($"초기 카운트: {myQueue.Count}");

            Console.WriteLine("큐가 비었을 때 픽 시도");
            myQueue.Peek();

            Console.WriteLine("큐가 비었을 때 디큐 시도");
            myQueue.Dequeue();

            Console.WriteLine("엔큐: 111");
            myQueue.Enqueue(111);
            Console.WriteLine($"카운트: {myQueue.Count}");
            Console.WriteLine($"픽: {myQueue.Peek()}");

            Console.WriteLine("엔큐: 222");
            myQueue.Enqueue(222);
            Console.WriteLine($"카운트: {myQueue.Count}");
            Console.WriteLine($"픽: {myQueue.Peek()}");

            Console.WriteLine("엔큐: 333");
            myQueue.Enqueue(333);
            Console.WriteLine($"카운트: {myQueue.Count}");
            Console.WriteLine($"픽: {myQueue.Peek()}");

            Console.WriteLine("디큐");
            myQueue.Dequeue();
            Console.WriteLine($"카운트: {myQueue.Count}");
            Console.WriteLine($"픽: {myQueue.Peek()}");

            Console.WriteLine("디큐");
            myQueue.Dequeue();
            Console.WriteLine($"카운트: {myQueue.Count}");
            Console.WriteLine($"픽: {myQueue.Peek()}");
        }
    }
}
