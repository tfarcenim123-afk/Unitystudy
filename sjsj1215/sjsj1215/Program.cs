internal class Program
{
    static void Main()
    {
        List<int> list = new List<int>();

        Random random = new Random();

        int number = 0;

        for (int i = 0; i < random.Next(10, 20); i++)
        {
            number += random.Next(1, 10);

            list.Add(number);

            Console.Write(number + " ");
        }

        Console.WriteLine();

        Console.Write("Target number : ");
        int input = int.Parse(Console.ReadLine());

        Console.Write("Is there target number? : ");
        Console.WriteLine(BinarySearch(list, input));

        Console.Write("Index of Lower Bound is ");
        Console.WriteLine(LowerBound(list, input));

        Console.Write("Index of Upper Bound is ");
        Console.WriteLine(UpperBound(list, input));
    }

    ///<summary>
    ///이진탐색
    ///</summary>
    static bool BinarySearch(List<int> list, int key)
    {
        int min = 0;
        int max = list.Count;
        int mid;

        while (min < max)
        {
            mid = (min + max)/2;

            if (list[mid] == key) return true;

            if (list[mid] > key) //key가 중앙값보다 왼쪽에 있다면
            {
                max = mid;
            }
            else //key가 중앙값보다 오른쪽에 있다면
            {
                min = mid + 1;
            }
        }

        return false;
    }

    ///<summary>
    ///list 내에서 key보다 크거나 같은 첫 번째 원소의 인덱스를 반환한다.
    ///</summary>
    static int LowerBound(List<int> list, int key)
    {
        int min = 0;
        int max = list.Count;
        int mid;
        int result = list.Count;

        while (min < max) //리스트의 크기가 2이상이면 반복
        {
            mid = (min + max) / 2; //mid 인덱스 구하기

            if (list[mid] < key) //key 값이 mid보다 크면
            {
                min = mid + 1; //mid 오른쪽 다시 탐색
            }
            else //key 값이 mid보다 작거나 같으면
            {
                result = mid; //mid 값이 정답일 수도 있고
                max = mid; //mid 왼쪽 다시 탐색
            }
        }

        return result;
    }

    ///<summary>
    ///list 내에서 key보다 큰 첫 번째 원소의 인덱스를 반환한다.
    ///</summary>
    static int UpperBound(List<int> list, int key)
    {
        int min = 0;
        int max = list.Count;
        int mid;
        int result = list.Count;

        while (min < max) //리스트의 크기가 2이상이면 반복
        {
            mid = (min + max) / 2; //mid 인덱스 구하기

            if (list[mid] > key) //key 값이 mid보다 작으면
            {
                result = mid; //mid 값이 정답일 수도 있고
                max = mid; //mid 왼쪽 다시 탐색
            }
            else //key 값이 mid보다 크거나 같으면
            {
                min = mid + 1; //mid 오른쪽 다시 탐색
            }
        }

        return result;
    }
}

//static int LowerBound(List<int> list, int key)
//{
//    foreach (int i in list)
//    {
//        if(i >= key)
//        {
//            return list.IndexOf(i);
//        }
//    }

//    return -1;
//}

//static int UpperBound(List<int> list, int key)
//{
//    foreach (int i in list)
//    {
//        if (i > key)
//        {
//            return list.IndexOf(i);
//        }
//    }

//    return -1;
//}

//static bool BinarySearch(List<int> list, int key)
//{
//    if (list[list.Count / 2] == key)
//    {
//        return true;
//    }

//    else if (list.Count / 2 > 0)
//    {
//        if (list[list.Count / 2] > key)
//        {
//            List<int> nextList = new List<int>();
//            nextList = list.GetRange(0, list.Count / 2);
//            return BinarySearch(nextList, key);
//        }

//        if (list[list.Count / 2] < key)
//        {
//            List<int> nextList = new List<int>();
//            nextList = list.GetRange(list.Count / 2 + 1, (list.Count - 1) / 2);
//            return BinarySearch(nextList, key);
//        }
//    }

//    return false;
//}