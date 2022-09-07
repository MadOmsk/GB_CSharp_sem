// Программа определяет в какой плоскости находится точка с введённым координатами.
using EducationLibraries;

internal class Task17 : Task, IRunnableFromConsole
{
    private static string description = "Программа определяет в какой плоскости находится точка с введённым координатами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        Console.WriteLine("Введите координаты X Y");
        string xy = Console.ReadLine()!;
        string[] parts = xy.Split(' ');
        int x = int.Parse(parts[0]);
        int y = int.Parse(parts[1]);

        if (x > 0 && y > 0)
            Console.WriteLine("1-я четверть");
        else if (x < 0 && y > 0)
            Console.WriteLine("2-я четверть");
        else if (x < 0 && y < 0)
            Console.WriteLine("3-я четверть");
        else if (x > 0 && y < 0)
            Console.WriteLine("4-я четверть");
        else
            Console.WriteLine("Точка находится на оси");
    }
}