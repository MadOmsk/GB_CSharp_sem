// Здесь вся геометрия.

// Класс точка, содержащий 2 координаты.
public class Point2D
{
    // Создаёт объект по двум координатам.
    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Создаёт объект из строки.
    public Point2D(string input)
    {
        string[] pointString = input.Split(' ');
        X = int.Parse(pointString[0]);
        Y = int.Parse(pointString[1]);
    }

    // Координаты.
    public int X, Y;

    // Расчитывает расстояние между двумя точками на декартовой плоскости, возвращает double.
    public static double CalculateDistance(Point2D a, Point2D b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}

// Класс точка, содержащий 3 координаты.
public class Point3D
{
    // Создаёт объект по трём координатам.
    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Создаёт объект из строки.
    public Point3D(string input)
    {
        string[] pointString = input.Split(' ');
        var inputInt = new int[3];
        X = int.Parse(pointString[0]);
        Y = int.Parse(pointString[1]);
        Z = int.Parse(pointString[2]);
    }

    // Координаты.
    public int X, Y, Z;

    // Расчитывает расстояние между двумя точками на декартовом пространстве, возвращает double.
    public static double CalculateDistance(Point3D a, Point3D b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));
    }
}
