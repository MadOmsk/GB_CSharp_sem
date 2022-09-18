// Программа считает количество разрядов числа.
using EducationLibraries;

internal class Task26 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает число количество числа.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInputOutput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        System.Console.WriteLine($"Количество разрядов числа {number} - {GetDepth(number)}");
    }

    // Метод считает количество разрядов числа.
    private static int GetDepth(int number)
    {
        int depth = 0;
        while (number > 0)
        {
            number /= 10;
            depth++;
        }
        return depth;
    }
}