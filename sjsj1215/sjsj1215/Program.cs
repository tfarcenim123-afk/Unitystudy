internal class Program
{
    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 4, 8, 16, 32, 64 };

        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(BinarySearch(list, input));

        Console.WriteLine(LowerBound(list, input));

        Console.WriteLine(UpperBound(list, input));
    }

    ///<summary>
    ///이진탐색
    ///</summary>
    static bool BinarySearch(List<int> list, int key)
    {
        if (list[list.Count / 2] == key)
        {
            return true;
        }

        else if (list.Count / 2 > 0)
        {
            if (list[list.Count / 2] > key)
            {
                List<int> nextList = new List<int>();
                nextList = list.GetRange(0, list.Count / 2);
                return BinarySearch(nextList, key);
            }

            if (list[list.Count / 2] < key)
            {
                List<int> nextList = new List<int>();
                nextList = list.GetRange(list.Count / 2 + 1, (list.Count - 1) / 2);
                return BinarySearch(nextList, key);
            }
        }

        return false;
    }

    ///<summary>
    ///list 내에서 key보다 크거나 같은 첫 번째 원소의 인덱스를 반환한다.
    ///</summary>
    static int LowerBound(List<int> list, int key)
    {
        foreach (int i in list)
        {
            if(i >= key)
            {
                return list.IndexOf(i);
            }
        }

        return -1;
    }

    ///<summary>
    ///list 내에서 key보다 큰 첫 번째 원소의 인덱스를 반환한다.
    ///</summary>
    static int UpperBound(List<int> list, int key)
    {
        foreach (int i in list)
        {
            if (i > key)
            {
                return list.IndexOf(i);
            }
        }

        return -1;
    }
}
