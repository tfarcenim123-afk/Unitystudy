internal class baekjoon_2805
{
    //static void Main()
    //{
    //    // 입력 속도 향상을 위해 한 번에 읽기
    //    string[] firstLine = Console.ReadLine().Split();
    //    int N = int.Parse(firstLine[0]);
    //    int M = int.Parse(firstLine[1]);

    //    int[] trees = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    //    long minH = 0;
    //    long maxH = trees.Max(); // 나무 중 가장 높은 값을 max로 설정
    //    long resultH = 0;

    //    // 이분 탐색 시작
    //    while (minH <= maxH)
    //    {
    //        long midH = (minH + maxH) / 2;
    //        long totalCut = 0; // 자른 나무의 합은 반드시 long

    //        foreach (int tree in trees)
    //        {
    //            if (tree > midH)
    //            {
    //                totalCut += (tree - midH);
    //            }
    //        }

    //        if (totalCut >= M)
    //        {
    //            // 나무를 충분히 얻었으므로, 높이를 더 높여본다 (최댓값 찾기)
    //            resultH = midH;
    //            minH = midH + 1;
    //        }
    //        else
    //        {
    //            // 나무가 부족하므로, 높이를 낮춰야 한다
    //            maxH = midH - 1;
    //        }
    //    }

    //    Console.Write(resultH);
    //}
}
