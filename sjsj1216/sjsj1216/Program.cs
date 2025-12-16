using System.Text;
        internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine()); // N 입력

            string[] arrayN = Console.ReadLine().Split(); // 크기가 N인 정수 배열

            int M = int.Parse(Console.ReadLine()); // M 입력

            string[] arrayM = Console.ReadLine().Split(); // 크기가 M인 정수 배열

            Array.Sort(arrayN);

            StringBuilder sb = new StringBuilder(N);

            foreach (string m in arrayM)
            {
                if (Array.BinarySearch(arrayN, m) > -1)
                {
                    sb.AppendLine("1");
                    continue;
                }

                sb.AppendLine("0");
            }

            Console.WriteLine(sb);
        }
    }

    //int N = int.Parse(Console.ReadLine()); // N 입력

    //    string[] arrayN = Console.ReadLine().Split(); // 크기가 N인 정수 배열

    //    for(int i = 0; i < 10; i++)
    //    {

    //    }
    //    int[] groupA = new int[N];  //log31~30
    //    int[] groupB = new int[N];  //log30~28
    //    int[] groupC = new int[N];  //log28~24
    //    int[] groupD = new int[N];  //log24~16
    //    int[] groupE = new int[N];  //log16~00
    //    int[] groupF = new int[N];  //log00~16
    //    int[] groupG = new int[N];  //log16~24
    //    int[] groupH = new int[N];  //log24~28
    //    int[] groupI = new int[N];  //log28~30
    //    int[] groupJ = new int[N];  //log30~31

    //    int M = int.Parse(Console.ReadLine()); // M 입력

    //    string[] arrayM = Console.ReadLine().Split(); // 크기가 M인 정수 배열

        //List<int> list = Console.ReadLine()!.Split().Select(int.Parse).ToList();

//bool[] isThereSameNumberPstv1 = new bool[int.MaxValue / 2 + 1]; // 0부터 2^30-1 까지
//bool[] isThereSameNumberPstv2 = new bool[int.MaxValue / 2 + 1]; // 2^30 부터 2^31-1 까지
//bool[] isThereSameNumberNgtv1 = new bool[int.MaxValue / 2 + 1]; // -1부터 -2^30 까지
//bool[] isThereSameNumberNgtv2 = new bool[int.MaxValue / 2 + 1]; // -2^30-1부터 -2^31까지

//foreach (string n in arrayN)
//{
//    int i = int.Parse(n);

//    if (0 <= i && i <= int.MaxValue / 2)
//    {
//        isThereSameNumberPstv1[i] = true;
//    }
//    if (int.MaxValue / 2 < i)
//    {
//        isThereSameNumberPstv2[i - (int.MaxValue / 2) - 1] = true;
//    }
//    if (-(int.MaxValue / 2) - 1 <= i && i < 0)
//    {
//        isThereSameNumberNgtv1[-i - 1] = true;
//    }
//    if (i < -(int.MaxValue / 2) - 1)
//    {
//        isThereSameNumberNgtv2[-i - (int.MaxValue / 2) + 2] = true;
//    }
//}

//int M = int.Parse(Console.ReadLine()); // M 입력

//string[] arrayM = Console.ReadLine().Split(); // 크기가 M인 정수 배열

//foreach (string m in arrayM)
//{
//    int i = int.Parse(m);

//    if (0 <= i && i <= int.MaxValue / 2)
//    {
//        if (isThereSameNumberPstv1[i])
//        {
//            Console.WriteLine(1);
//            continue;
//        }
//    }
//    if (int.MaxValue / 2 < i)
//    {
//        if (isThereSameNumberPstv2[i - (int.MaxValue / 2) - 1])
//        {
//            Console.WriteLine(1);
//            continue;
//        }
//    }
//    if (-(int.MaxValue / 2) - 1 <= i && i < 0)
//    {
//        if (isThereSameNumberNgtv1[-i - 1])
//        {
//            Console.WriteLine(1);
//            continue;
//        }
//    }
//    if (i < -(int.MaxValue / 2) - 1)
//    {
//        if (isThereSameNumberNgtv2[-i - (int.MaxValue / 2) + 2])
//        {
//            Console.WriteLine(1);
//            continue;
//        }
//    }

//    else
//    {
//        Console.WriteLine(0);
//    }
//}

//int N = int.Parse(Console.ReadLine()); // N 입력

//string[] arrayN = Console.ReadLine().Split(); // 크기가 N인 정수 배열

//int M = int.Parse(Console.ReadLine()); // M 입력

//string[] arrayM = Console.ReadLine().Split(); // 크기가 M인 정수 배열

//Array.Sort(arrayN); //O(NlogN)

//foreach (string m in arrayM)
//{
//    if (Array.BinarySearch(arrayN, m) > -1)
//    {
//        Console.WriteLine(1);
//        continue;
//    }

//    Console.WriteLine(0);
//}