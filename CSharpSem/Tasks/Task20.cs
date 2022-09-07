// Программа рассчитывает расстояние между двумя точками.
using EducationLibraries;

internal class Task20 : Task, IRunnableFromConsole
{
    private static string description = "Программа рассчитывает расстояние между двумя точками.";

    new internal static void Run()
    {
        Console.WriteLine(description);
        
        Console.WriteLine("Введите координаты X Y первой точки (через пробел)");
        // Используется класс Point2D из библиотеки.
        var pointA = new Point2D(Console.ReadLine()!);

        Console.WriteLine("Введите координаты X Y второй точки (через пробел)");
        var pointB = new Point2D(Console.ReadLine()!);

        double distance = Point2D.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Расстояние между точками равно {distance:F2}");
    }
}

