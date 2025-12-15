internal class Program
{
    static int userInput;
    static void Main( )
    {
        userInput = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");

        Crazy(userInput);

        Console.Write("라고 답변하였지.");
    }

    static void Crazy(int input)
    {
        if (input == 0)
        {
            UnderBar(input);
            Console.WriteLine("\"재귀함수가 뭔가요?\"");
            UnderBar(input);
            Console.WriteLine("\"재귀함수는 자기 자신을 호출하는 함수라네\"");

            return;
        }

        BlaBla(input);

        Crazy(input - 1);

        UnderBar(input - 1);
        Console.WriteLine("라고 답변하였지.");
    }

    static void BlaBla(int input)
    {
        UnderBar(input);
        Console.WriteLine("\"재귀함수가 뭔가요?\"");
        UnderBar(input);
        Console.WriteLine("\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
        UnderBar(input);
        Console.WriteLine("마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
        UnderBar(input);
        Console.WriteLine("그의 답은 대부분 옳았다고 하네.그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");
    }

    static void UnderBar(int input) 
    {
        for (; input < userInput; input++)
        {
            Console.Write("____");
        }
    }
}
    //1번
    //어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.

    //(n - 1)번 반복
    //(____)"재귀함수가 뭔가요?"
    //(____)"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.
    //(____)마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.
    //(____)그의 답은 대부분 옳았다고 하네.그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어."
    

    //마지막 1번
    //(____)"재귀함수가 뭔가요?"
    //(____)"재귀함수는 자기 자신을 호출하는 함수라네"


    //int input = int.Parse(Console.ReadLine());

    //int result = GetFactorial(input);

    //Console.WriteLine(result);

    //static void Foo(int i)
    //{
    //    if (i > 1)
    //    {
    //        Foo(i - 1);
    //    }

    //    Console.WriteLine(i);
    //}

    //static void Foo(int i)
    //{
    //    if (i < 1)
    //    {
    //      return;    
    //    }
    //
    //    Foo(i - 1);
    //
    //    Console.WriteLine(i);
    //}

    //static void ToBinary(int i)
    //{
    //    if (i < 1)
    //    {
    //        return;
    //    }

    //    ToBinary(i / 2);

    //    Console.Write(i % 2);
    //}

    //static int GetFactorial(int i)
    //{
    //    if (i < 1)
    //    {
    //        return 1;
    //    }

    //    return i * GetFactorial(i - 1);
    //}
