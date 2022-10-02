// Программа находит сумму натуральных чисел в промежутке от M до N (рекурсивно).
using EducationLibraries;

internal class Task66 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит сумму натуральных чисел в промежутке от M до N (рекурсивно).";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int[] range = EdInputOutput.InputConsoleInteger("Введите диапазон целых чисел (через пробел)", 2, Algebra.Sets.Z);
        int min = Algebra.Min(range[0], range[1]);
        int max = Algebra.Max(range[0], range[1]);

        // Если оба числа неположительные, то выводит сообщение, что в этом промежутке нет натуральных чисел.
        if (min <= 0 && max <= 0)
        {
            System.Console.WriteLine("В этом диапазоне нет натуральных чисел");
            return;
        }

        // Если только min неположительный, то min = 1.
        if (min <= 0)
            min = 1;

        Console.WriteLine(GetSum(min, max));

    }

    // Находит сумму чисел от m до n (рекурсивно).
    private static int GetSum(int m, int n)
    {
        if (n == m)
            return m;

        return GetSum(m, n - 1) + n;
    }
}