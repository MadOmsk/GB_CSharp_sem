// Программа рассчитывает расстояние между двумя точками в трёхмерном пространстве.
using EducationLibraries;

internal class Task21 : Task, IRunnableFromConsole
{
    private static string description = "Программа рассчитывает расстояние между двумя точками в трёхмерном пространстве.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        // Используется класс Point3D из моей библиотеки.
        var pointA = new Point3D(EdInput.InputConsoleDouble("Введите координаты X Y Z первой точки (через пробел)", 3));
        var pointB = new Point3D(EdInput.InputConsoleDouble("Введите координаты X Y Z второй точки (через пробел)", 3));

        double distance = Point3D.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Расстояние между точками равно {distance:F2}");
    }
}
