internal class Program
    {
        static void Output(int a, int b) //함수 선언
        {
            Console.WriteLine(a+b);
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
        
            Output(a,b); //함수 호출

            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }


    }
}

