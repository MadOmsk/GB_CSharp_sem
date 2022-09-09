// Программа считает количество разрядов числа.
using EducationLibraries;

internal class Task26 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает число количество числа.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInput.ConsoleInt("Введите натуральное число");

        // Число разрядов.
        int depth = 0;
        while (number > 0)
        {
            number /= 10;
            depth++;
        }

        System.Console.WriteLine($"Число количество числа {number} - {depth}");
    }
}