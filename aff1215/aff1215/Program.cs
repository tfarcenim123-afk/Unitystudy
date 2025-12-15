using System.Collections;

internal class Program
{
    public static string? inputText;

    public static LinkedList<char> inputTextList;

    public static LinkedListNode<char>? cursor;
    static void Cursor(string input)
    {
        if (input.Length == 1)
        {
            switch (input[0])
            {
                case 'L':
                    if (cursor == inputTextList.First) return;
                    cursor = cursor.Previous;
                    break;

                case 'D':
                    if (cursor == inputTextList.Last) return;
                    cursor = cursor.Next;
                    break;

                case 'B':
                    if (cursor == inputTextList.First) return;
                    inputTextList.Remove(cursor.Previous);
                    break;

                default:
                    break;
            }

            return;
        }

        else
        {
            inputTextList.AddBefore(cursor, input[2]);
        }

    }

    static void Main()
    {
        inputText = Console.ReadLine();

        inputTextList = new LinkedList<char>(inputText);

        inputTextList.AddLast(' ');

        cursor = inputTextList.Last;

        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputNumber; i++)
        {
            Cursor(Console.ReadLine());
        }

        inputTextList.RemoveLast();
        
        Console.Write(string.Concat(inputTextList));
        
    }
}


    //class MyLinkedListNode
    //{
    //    private int _value;

    //    private MyLinkedListNode? _prevNode;
    //    private MyLinkedListNode? _nextNode;

    //}

    //L 커서를 왼쪽으로 한 칸 옮김(커서가 문장의 맨 앞이면 무시됨)
    //D 커서를 오른쪽으로 한 칸 옮김(커서가 문장의 맨 뒤이면 무시됨)
    //B 커서 왼쪽에 있는 문자를 삭제함(커서가 문장의 맨 앞이면 무시됨)
    //삭제로 인해 커서는 한 칸 왼쪽으로 이동한 것처럼 나타나지만, 실제로 커서의 오른쪽에 있던 문자는 그대로임
    //P $	$라는 문자를 커

    //class MyArrayIterator : IEnumerator<int>
    //{
    //    public int Current => throw new NotImplementedException();

    //    object IEnumerator.Current => Current;

    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool MoveNext()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class MyArray : IEnumerable<int>
    //{
    //    private int[] _container = { 1, 2, 3 };

    //    public IEnumerator<int> GetEnumerator()
    //    {
    //        for (int i = 0; i < _container.Length; i++)
    //        {
    //            yield return _container[i];
    //        }
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}
    //    static void Main()
    //{
    //MyArray myArray = new MyArray();

    //foreach (int i in myArray)
    //{
    //    Console.WriteLine(i);
    //}

    //// ==

    //IEnumerator myArrayIterator = myArray.GetEnumerator();

    //while (true)
    //{
    //    int current = (int)myArrayIterator.Current;

    //    Console.WriteLine(current);

    //    myArrayIterator.MoveNext();

    //    if (myArrayIterator.MoveNext() == false) break;
    //}

    //List<int> myList = new List<int>();

    //myList.Add(3);
    //myList.Add(2);
    //myList.Add(14);
    //myList.Add(20);
    //myList.Insert(2, 10);

    //foreach (int i in myList)
    //{
    //    Console.Write( i + " " );
    //}


    //}

