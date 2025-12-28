//internal class baekjoon_2110
//{
//    static void Main()
//    {
//        //입력
//        //첫째 줄에 집의 개수 N (2 ≤ N ≤ 200,000)과 공유기의 개수 C (2 ≤ C ≤ N)이
//        //하나 이상의 빈 칸을 사이에 두고 주어진다.
//        string[] firstLine = Console.ReadLine().Split();
//        int N = int.Parse(firstLine[0]);
//        int C = int.Parse(firstLine[1]);

//        //도현이의 집 N개가 수직선 위에 있다.
//        //각각의 집의 좌표는 x1, ..., xN이고, 집 여러개가 같은 좌표를 가지는 일은 없다.
//        //둘째 줄부터 N개의 줄에는 집의 좌표를 나타내는 xi (0 ≤ xi ≤ 1,000,000,000)가
//        //한 줄에 하나씩 주어진다.
//        int[] houses = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            houses[i] = int.Parse(Console.ReadLine());
//        }

//        Array.Sort(houses); //O(N)

//        int min = 1;
//        int max = houses[N - 1] - houses[0];
//        int answer = 0;

//        while (min <= max)
//        {
//            int mid = (min + max) / 2;
//            int count = 1;
//            int lastHouse = houses[0]; 

//            for (int i = 1; i < N; i++)
//            {
//                if (houses[i] - lastHouse >= mid) // 간격이 mid 이상이면 설치
//                {
//                    count++;
//                    lastHouse = houses[i];
//                }
//            }

//            if (count >= C)
//            {
//                answer = mid;
//                min = mid + 1;
//            }

//            if (count < C)
//            {
//                max = mid - 1;
//            }

//        }

//        Console.WriteLine(answer);
//    }
//}
//N개의 점이 주어진다. (2 ≤ N ≤ 200,000)
//그 중 C개의 점만 쓴다. (2 ≤ C ≤ N)
//C끼리의 거리 중 최소값을 구한다.
//그 최소값의 최대값을 구하는 문제
//답은 1 ≤ a ≤ S 사이에 있다. 이 사이를 이진탐색.
//X[i] 와 X[i+1] 의 거리(값 차이)가 a보다 작으면 건너뛴다(a가 최소값이라고 가정하고 있으니까)
//a보다 크거나 같으면 카운트를 올린다.
//카운트가 같으면 정답일수도 있으니 저장하고 더 작은 범위 탐색.
//카운트가 작으면 a를 줄여야하니까 더 작은 범위 탐색
//카운트가 더크면 a를 늘려서 더 큰 범위 탐색


//이미 있는 2개와 가장 거리가 크게 설치하려면 중앙이어야 함

//도현이는 언제 어디서나 와이파이를 즐기기 위해서 집에 공유기 C개를 설치하려고 한다.
//최대한 많은 곳에서 와이파이를 사용하려고 하기 때문에, 한 집에는 공유기를 하나만 설치할 수 있고,
//가장 인접한 두 공유기 사이의 거리를 가능한 크게 하여 설치하려고 한다.

//C개의 공유기를 N개의 집에 적당히 설치해서,
//가장 인접한 두 공유기 사이의 거리를 최대로 하는 프로그램을 작성하시오.




//출력
//첫째 줄에 가장 인접한 두 공유기 사이의 최대 거리를 출력한다.