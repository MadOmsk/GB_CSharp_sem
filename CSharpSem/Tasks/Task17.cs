// Программа определяет в какой плоскости находится точка с введённым координатами.
using EducationLibraries;

internal class Task17 : Task, IRunnableFromConsole
{
    private static string description = "Программа определяет в какой плоскости находится точка с введённым координатами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        double[] xy = EdInputOutput.InputConsoleDouble("Введите координаты X Y (через пробел)", 2);
        var point = new Point2D(xy);

        if (point._x > 0 && point._y > 0)
            Console.WriteLine("1-я четверть");
        else if (point._x < 0 && point._y > 0)
            Console.WriteLine("2-я четверть");
        else if (point._x < 0 && point._y < 0)
            Console.WriteLine("3-я четверть");
        else if (point._x > 0 && point._y < 0)
            Console.WriteLine("4-я четверть");
        else
            Console.WriteLine("Точка находится на оси");
    }
}