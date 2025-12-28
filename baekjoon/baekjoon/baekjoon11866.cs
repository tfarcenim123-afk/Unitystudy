//using System.Text;

//internal class baekjoon11866
//{
//    static void Main()
//    {
//        //N과 K가 주어지면 (N, K)-요세푸스 순열을 구하는 프로그램을 작성하시오.

//        //입력
//        //첫째 줄에 N과 K가 빈 칸을 사이에 두고 순서대로 주어진다. (1 ≤ K ≤ N ≤ 1,000)
//        string[] input = Console.ReadLine().Split();
//        int N = int.Parse(input[0]);
//        int K = int.Parse(input[1]);

//        Queue<int> numbers = new Queue<int>(N);
//        StringBuilder answer = new StringBuilder();

//        answer.Append("<");

//        for (int i = 1; i <= N; i++)
//        {
//            numbers.Enqueue(i);
//        }

//        int loop = 0;

//        while (numbers.Count > 1)
//        {
//            loop++;

//            int x = numbers.Dequeue();

//            if (loop % K == 0)
//            {
//                answer.Append($"{x}, ");
//            }

//            else
//            {
//                numbers.Enqueue(x);
//            }
//        }

//        answer.Append($"{numbers.Dequeue()}>");

//        Console.WriteLine( answer.ToString() );
//    }
//}

//요세푸스 문제는 다음과 같다.

//1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고, 양의 정수 K(≤ N)가 주어진다.
//이제 순서대로 K번째 사람을 제거한다. 한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다.
//이 과정은 N명의 사람이 모두 제거될 때까지 계속된다. 원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다.
//예를 들어 (7, 3)-요세푸스 순열은 <3, 6, 2, 7, 5, 1, 4>이다.
//1,2,(3),4,5,(6),7,1,(2),4,5,(7),1,4,(5),1,4,(1),4,4,(4)

//왜 이게 큐 문제일까

//K번째가 아니면 디큐,엔큐 반복(가장 마지막으로 보내기)
//K번째면 디큐만 


//출력
//예제와 같이 요세푸스 순열을 출력한다.

//예제 입력 1 
//7 3
//예제 출력 1 
//<3, 6, 2, 7, 5, 1, 4>