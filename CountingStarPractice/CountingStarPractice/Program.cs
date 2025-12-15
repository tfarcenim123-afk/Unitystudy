using System.ComponentModel;

internal class Program
{
    static void Main()
    {
        int result = 0;
        
        string[] abc = Console.ReadLine().Split(" ");
        string[] x = Console.ReadLine().Split(" ");
        string[] y = Console.ReadLine().Split(" ");
        string[] z = Console.ReadLine().Split(" ");

        int a = int.Parse(abc[0]) * 1;
        int b = int.Parse(abc[1]) * 2;
        int c = int.Parse(abc[2]) * 3;

        int xMin = int.Parse(x[0]);
        int xMax = int.Parse(x[1]);
        int yMin = int.Parse(y[0]);
        int yMax = int.Parse(y[1]);
        int zMin = int.Parse(z[0]);
        int zMax = int.Parse(z[1]);

        bool xyz = xMin <= yMin && yMin <= zMin;
        bool xzy = xMin <= zMin && zMin <= yMin;
        bool yxz = yMin <= xMin && xMin <= zMin;
        bool yzx = yMin <= zMin && zMin <= xMin;
        bool zyx = zMin <= yMin && yMin <= xMin;
        bool zxy = zMin <= xMin && xMin <= yMin;

        bool zyx2 = zMax <= yMax && yMax <= xMax;
        bool yzx2 = yMax <= zMax && zMax <= xMax;
        bool zxy2 = zMax <= xMax && xMax <= yMax;
        bool xzy2 = xMax <= zMax && zMax <= yMax;
        bool xyz2 = xMax <= yMax && yMax <= zMax;
        bool yxz2 = yMax <= xMax && xMax <= zMax;

        if (xyz && xyz2)
        {
            result = (yMin - xMin) * a + (zMin - yMin) * b + (xMax - zMin) * c + (yMax - xMax) * b + (zMax - yMax) * a;
        }

        if (xyz && xzy2)
        {
            result = (yMin - xMin) * a + (zMin - yMin) * b + (xMax - zMin) * c + (zMax - xMax) * b + (yMax - zMax) * a;
        }

        if (xyz && yxz2)
        {
            result = (yMin - xMin) * a + (zMin - yMin) * b + (yMax - zMin) * c + (xMax - yMax) * b + (zMax - xMax) * a;
        }

        if (xyz && yzx2)
        {
            result = (yMin - xMin) * a + (zMin - yMin) * b + (yMax - zMin) * c + (zMax - yMax) * b + (xMax - zMax) * a;
        }

        if (xyz && zyx2)
        {
            result = (yMin - xMin) * a + (zMin - yMin) * b + (zMax - zMin) * c + (yMax - zMax) * b + (xMax - yMax) * a;
        }

        if (xyz && zxy2)
        {
            result = (yMin - xMin) * a + (zMin - yMin) * b + (zMax - zMin) * c + (xMax - zMax) * b + (yMax - xMax) * a;
        }

        //

        if (xzy && xyz2)
        {
            result = (zMin - xMin) * a + (yMin - zMin) * b + (xMax - yMin) * c + (yMax - xMax) * b + (zMax - yMax) * a;
        }

        if (xzy && xzy2)
        {
            result = (zMin - xMin) * a + (yMin - zMin) * b + (xMax - yMin) * c + (zMax - xMax) * b + (yMax - zMax) * a;
        }

        if (xzy && yxz2)
        {
            result = (zMin - xMin) * a + (yMin - zMin) * b + (yMax - yMin) * c + (xMax - yMax) * b + (zMax - xMax) * a;
        }

        if (xzy && yzx2)
        {
            result = (zMin - xMin) * a + (yMin - zMin) * b + (yMax - yMin) * c + (zMax - yMax) * b + (xMax - zMax) * a;
        }

        if (xzy && zyx2)
        {
            result = (zMin - xMin) * a + (yMin - zMin) * b + (zMax - yMin) * c + (yMax - zMax) * b + (xMax - yMax) * a;
        }

        if (xzy && zxy2)
        {
            result = (zMin - xMin) * a + (yMin - zMin) * b + (zMax - yMin) * c + (xMax - zMax) * b + (yMax - xMax) * a;
        }

        //

        if (yxz && xyz2)
        {
            result = (xMin - yMin) * a + (zMin - xMin) * b + (xMax - zMin) * c + (yMax - xMax) * b + (zMax - yMax) * a;
        }

        if (yxz && xzy2)
        {
            result = (xMin - yMin) * a + (zMin - xMin) * b + (xMax - zMin) * c + (zMax - xMax) * b + (yMax - zMax) * a;
        }

        if (yxz && yxz2)
        {
            result = (xMin - yMin) * a + (zMin - xMin) * b + (yMax - zMin) * c + (xMax - yMax) * b + (zMax - xMax) * a;
        }

        if (yxz && yzx2)
        {
            result = (xMin - yMin) * a + (zMin - xMin) * b + (yMax - zMin) * c + (zMax - yMax) * b + (xMax - zMax) * a;
        }

        if (yxz && zyx2)
        {
            result = (xMin - yMin) * a + (zMin - xMin) * b + (zMax - zMin) * c + (yMax - zMax) * b + (xMax - yMax) * a;
        }

        if (yxz && zxy2)
        {
            result = (xMin - yMin) * a + (zMin - xMin) * b + (zMax - zMin) * c + (xMax - zMax) * b + (yMax - xMax) * a;
        }

        //

        if (yzx && xyz2)
        {
            result = (zMin - yMin) * a + (xMin - zMin) * b + (xMax - xMin) * c + (yMax - xMax) * b + (zMax - yMax) * a;
        }

        if (yzx && xzy2)
        {
            result = (zMin - yMin) * a + (xMin - zMin) * b + (xMax - xMin) * c + (zMax - xMax) * b + (yMax - zMax) * a;
        }

        if (yzx && yxz2)
        {
            result = (zMin - yMin) * a + (xMin - zMin) * b + (yMax - xMin) * c + (xMax - yMax) * b + (zMax - xMax) * a;
        }

        if (yzx && yzx2)
        {
            result = (zMin - yMin) * a + (xMin - zMin) * b + (yMax - xMin) * c + (zMax - yMax) * b + (xMax - zMax) * a;
        }

        if (yzx && zyx2)
        {
            result = (zMin - yMin) * a + (xMin - zMin) * b + (zMax - xMin) * c + (yMax - zMax) * b + (xMax - yMax) * a;
        }

        if (yzx && zxy2)
        {
            result = (zMin - yMin) * a + (xMin - zMin) * b + (zMax - xMin) * c + (xMax - zMax) * b + (yMax - xMax) * a;
        }

        //

        if (zyx && xyz2)
        {
            result = (yMin - zMin) * a + (xMin - yMin) * b + (xMax - xMin) * c + (yMax - xMax) * b + (zMax - yMax) * a;
        }

        if (zyx && xzy2)
        {
            result = (yMin - zMin) * a + (xMin - yMin) * b + (xMax - xMin) * c + (zMax - xMax) * b + (yMax - zMax) * a;
        }

        if (zyx && yxz2)
        {
            result = (yMin - zMin) * a + (xMin - yMin) * b + (yMax - xMin) * c + (xMax - yMax) * b + (zMax - xMax) * a;
        }

        if (zyx && yzx2)
        {
            result = (yMin - zMin) * a + (xMin - yMin) * b + (yMax - xMin) * c + (zMax - yMax) * b + (xMax - zMax) * a;
        }

        if (zyx && zyx2)
        {
            result = (yMin - zMin) * a + (xMin - yMin) * b + (zMax - xMin) * c + (yMax - zMax) * b + (xMax - yMax) * a;
        }

        if (zyx && zxy2)
        {
            result = (yMin - zMin) * a + (xMin - yMin) * b + (zMax - xMin) * c + (xMax - zMax) * b + (yMax - xMax) * a;
        }

        //

        if (zxy && xyz2)
        {
            result = (xMin - zMin) * a + (yMin - xMin) * b + (xMax - yMin) * c + (yMax - xMax) * b + (zMax - yMax) * a;
        }

        if (zxy && xzy2)
        {
            result = (xMin - zMin) * a + (yMin - xMin) * b + (xMax - yMin) * c + (zMax - xMax) * b + (yMax - zMax) * a;
        }

        if (zxy && yxz2)
        {
            result = (xMin - zMin) * a + (yMin - xMin) * b + (yMax - yMin) * c + (xMax - yMax) * b + (zMax - xMax) * a;
        }

        if (zxy && yzx2)
        {
            result = (xMin - zMin) * a + (yMin - xMin) * b + (yMax - yMin) * c + (zMax - yMax) * b + (xMax - zMax) * a;
        }

        if (zxy && zyx2)
        {
            result = (xMin - zMin) * a + (yMin - xMin) * b + (zMax - yMin) * c + (yMax - zMax) * b + (xMax - yMax) * a;
        }

        if (zxy && zxy2)
        {
            result = (xMin - zMin) * a + (yMin - xMin) * b + (zMax - yMin) * c + (xMax - zMax) * b + (yMax - xMax) * a;
        }

        Console.WriteLine(result);

    }
}
