internal class Program
    {
        static void Main()
        {
            for (int m = 1; m <= 5; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int m = 1; m <= 5; m++)
            {
                for (int n = 5; n >= m; n--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int n = 1; n <= 10; n++)
            {
                if (n % 2 == 1)
                    Console.WriteLine($"{n}은 홀수입니다.");
                else
                    Console.WriteLine($"{n}은 짝수입니다.");
            }
        }
    }
