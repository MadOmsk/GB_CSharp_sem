// Программа рассчитывает расстояние между двумя точками в трёхмерном пространстве.
using EducationLibraries;

internal class Task21 : Task, IRunnableFromConsole
{
    private static string description = "Программа рассчитывает расстояние между двумя точками в трёхмерном пространстве.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        Console.WriteLine("Введите координаты X Y Z первой точки (через пробел)");
        // Используется класс Point3D из библиотеки.
        var pointA = new Point3D(Console.ReadLine()!);

        Console.WriteLine("Введите координаты X Y Z второй точки (через пробел)");
        var pointB = new Point3D(Console.ReadLine()!);

        double distance = Point3D.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Расстояние между точками равно {distance:F2}");
    }
}
