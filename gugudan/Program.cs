    internal class Program
    {
        static void Main()
        {
            for (int n = 2; n <= 9; n++)
            {
                Console.WriteLine($"{n}단");
                for (int m = 1; m <= 9; m++)
                {
                    Console.WriteLine($"{n} x {m} = {n * m}");
                }
            }
        }
    }
