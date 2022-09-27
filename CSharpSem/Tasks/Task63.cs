// Программа выводит натуральные числа в промежутке от 1 до N (рекурсивно).
using EducationLibraries;

internal class Task63 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит натуральные числа в промежутке от 1 до N (рекурсивно).";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int n = EdInputOutput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        Console.WriteLine(GetNaturnalRow(n));
    }

    private static string GetNaturnalRow(int n)
    {
        if (n == 1)
            return "1";

        return GetNaturnalRow(n - 1) + ", " + n;
    }
}