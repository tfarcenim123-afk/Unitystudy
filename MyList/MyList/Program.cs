internal class Program
{
    class MyList
    {
        private int capacity = 1;
        private int count = 0;
        private int[] ints = new int[1];

        public void Add(int item)
        {
            if(count == capacity)
            {
                capacity *= 2;

                int[] newInts = new int[capacity];
                int newIntsIndex = 0;

                foreach (int i in ints)
                {
                    newInts[newIntsIndex] = i;
                    newIntsIndex++;
                }

                ints = newInts;
            }

            ints[count] = item;

            count++;
        }

        public void RemoveAt(int index)
        {
            if(index >= count || index < 0)
            {
                return;
            }

            else
            {
                for (int i = index; i + 1 < count; i++)
                    ints[i] = ints[i + 1];
            }

            count--;
        }

        public void Check()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();
        }
    }

    
    static void Main( )
    {
        MyList list = new MyList();

        list.Add(1);
        list.Check();
        list.Add(2);
        list.Check();
        list.Add(3);
        list.Check();
        list.Add(4);
        list.Check();
        list.Add(5);
        list.Check();

        list.RemoveAt(7);
        list.Check();
        list.RemoveAt(6);
        list.Check();
        list.RemoveAt(4);
        list.Check();
        list.RemoveAt(2);
        list.Check();
        list.RemoveAt(0);
        list.Check();
        list.RemoveAt(-2);
        list.Check();
    }
}