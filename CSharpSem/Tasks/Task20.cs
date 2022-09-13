// Программа рассчитывает расстояние между двумя точками.
using EducationLibraries;

internal class Task20 : Task, IRunnableFromConsole
{
    private static string description = "Программа рассчитывает расстояние между двумя точками.";

    new internal static void Run()
    {
        Console.WriteLine(description);
        
        // Используется класс Point2D из моей библиотеки.
        var pointA = new Point2D(EdInputOutput.InputConsoleDouble("Введите координаты X Y первой точки (через пробел)", 2));
        var pointB = new Point2D(EdInputOutput.InputConsoleDouble("Введите координаты X Y второй точки (через пробел)", 2));

        double distance = Point2D.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Расстояние между точками равно {distance:F2}");
    }
}

