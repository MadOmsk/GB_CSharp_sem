// Программа находит сумму целых чисел в промежутке от M до N (рекурсивно).
using EducationLibraries;

internal class Task66 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит сумму целых чисел в промежутке от M до N (рекурсивно).";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int[] range = EdInputOutput.InputConsoleInteger("Введите диапазон целых чисел (через пробел)", 2, Algebra.Sets.Z);
        int min = Algebra.Min(range[0], range[1]);
        int max = Algebra.Max(range[0], range[1]);

        Console.WriteLine(GetSum(min, max));

    }

    private static int GetSum(int m, int n)
    {
        if (n == m)
            return m;

        return GetSum(m, n - 1) +  n;
    }
}