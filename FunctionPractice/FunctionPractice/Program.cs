    internal class Program
    {
        //static void Sum(int start, int end)
        //{
        //    int sum = 0;

        //    for (int i = start; i <= end; i++)
        //    {
        //        sum += i;
        //    }

        //    Console.WriteLine(sum);
        //}

        //static void Main()
        //{
        //    Sum(1, 6);
        //}
        static int Sum(int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }
        static void Main()
        {
            int sum = Sum(1, 6);

            Console.WriteLine(sum);
        }
    }
