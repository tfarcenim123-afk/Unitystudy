namespace ConsoleApp1
{
    internal class Program
    {
        static int[] fibo = [];
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            fibo = new int[input + 1];

            Console.WriteLine(Fibonacci(input));
        }

        static public int Fibonacci(int input)
        {
            if (input == 0)
            {
                return 0;
            }

            if (input == 1)
            {
                return 1;
            }

            if (fibo[input] == 0)
            {
                fibo[input] = Fibonacci(input - 1) + Fibonacci(input - 2);
            }

            return fibo[input];
        }


        //public string Solution(int age)
        //{
        //    string abc = "abcdefghij";

        //    if (age == 0) return string.Empty;

        //    Solution(age / 10);

        //    string answer = abc[age % 10];

        //    return answer;
        //}
    }
}
