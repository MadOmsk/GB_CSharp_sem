/*Программа рассчитывает расстояние между двумя точками.*/
using EducationLibraries;

internal class Task20 : Task, IRunnableFromConsole
{
    private static string description = "Программа рассчитывает расстояние между двумя точками.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        Console.WriteLine("Введите координаты X Y первой точки");
        var pointA = new Point(Console.ReadLine()!);

        Console.WriteLine("Введите координаты X Y второй точки");
        var pointB = new Point(Console.ReadLine()!);

        double distance = Point.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Расстояние между точками равно {distance:F2}");
    }
}

/*Класс точка, содержащий 2 координаты*/
class Point
{
    /*Создаёт объект по двум координатам*/
    internal Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    /*Создаёт объект из строки*/
    internal Point(string input)
    {
        string[] pointString = input.Split(' ');
        X = int.Parse(pointString[0]);
        Y = int.Parse(pointString[1]);
    }

    internal int X, Y;

    /*Расчитывает расстояние между двумя точками на декартовой плоскости, возвращает double*/
    public static double CalculateDistance(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}
