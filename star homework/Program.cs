internal class Program
    {
    static void Main()
    {
        //왼쪽 정렬 1부터 5 별찍기
        for (int m = 1; m <= 5; m++)
        {
            for (int n = 1; n <= m; n++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //왼쪽 정렬 5부터 1 별찍기
        for (int m = 1; m <= 5; m++)
        {
            for (int n = 5; n >= m; n--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //오른쪽 정렬 5부터 1 별찍기
        for (int m = 1; m <= 5; m++)
        {
            for (int n = 1; n <= m; n++)
            {
                Console.Write(" ");
            }
            for (int j = 5; j >= m; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //오른쪽 정렬 1부터 5 별찍기
        for (int m = 1; m <= 5; m++)
        {
            for (int n = 5; n >= m; n--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= m; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //홀짝 판별
        for (int n = 1; n <= 10; n++)
        {
            if (n % 2 == 1)
                Console.WriteLine($"{n}은 홀수입니다.");
            else
                Console.WriteLine($"{n}은 짝수입니다.");
        }
    }
    }
