using System.Text;

internal class Program
{
    //정수를 저장하는 스택을 구현한 다음, 입력으로 주어지는 명령을 처리하는 프로그램을 작성하시오.

    //명령은 총 다섯 가지이다.

    public static List<int> stack = new List<int>();

    public static int input = 0;

    public static StringBuilder sb;
    static void Main()
    {
        input = int.Parse(Console.ReadLine());

        sb = new StringBuilder(input);

        for (int i = 0; i < input; i++)
        {
            string what = Console.ReadLine();

            switch (what)
            {
                case "pop":
                    {
                        Pop();
                    }
                    break;

                case "size":
                    {
                        Size();
                    }
                    break;

                case "empty":
                    {
                        Empty();
                    }
                    break;

                case "top":
                    {
                        Top();
                    }
                    break;

                default:
                    if (what.Contains("push"))
                    {
                        Push(int.Parse(what.Split()[1]));
                    }
                    break;
            }
        }

        Console.WriteLine(sb);
    }

    /// <summary>
    /// push X: 정수 X를 스택에 넣는 연산이다.
    /// </summary>
    static void Push(int X)
    {
        stack.Add(X);
    }

    /// <summary>
    /// pop: 스택에서 가장 위에 있는 정수를 빼고, 그 수를 출력한다. 
    ///     만약 스택에 들어있는 정수가 없는 경우에는 -1을 출력한다.
    /// </summary>
    static void Pop()
    {
        int pop = stack.Count - 1;

        if (pop < 0)
        {
            sb.AppendLine("-1");
            return;
        }

        sb.AppendLine($"{stack[pop]}");

        stack.RemoveAt(pop);
    }

    /// <summary>
    /// size: 스택에 들어있는 정수의 개수를 출력한다.
    /// </summary>
    static void Size()
    {
        sb.AppendLine($"{stack.Count}");
    }

    /// <summary>
    /// empty: 스택이 비어있으면 1, 아니면 0을 출력한다.
    /// </summary>
    static void Empty()
    {
        if (stack.Count == 0) sb.AppendLine("1");
        else sb.AppendLine("0");
    }

    /// <summary>
    /// top: 스택의 가장 위에 있는 정수를 출력한다. 
    ///     만약 스택에 들어있는 정수가 없는 경우에는 -1을 출력한다.
    /// </summary>
    static void Top()
    {
        int top = stack.Count - 1;

        if (top < 0)
        {
            sb.AppendLine("-1");
            return;
        }

        sb.AppendLine($"{stack[top]}");
    }
}