// Программа выводит натуральные числа в промежутке от M до N (рекурсивно).
using EducationLibraries;

internal class Task64 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит натуральные числа в промежутке от M до N (рекурсивно).";

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

        Console.WriteLine(GetRow(min, max));
    }

    // Выводит строку - целые числа в промежутке от m до n (по возрастанию). n должен быть больше m.
    private static string GetRow(int m, int n)
    {
        if (n == m)
            return m.ToString();

        return GetRow(m, n - 1) + ", " + n;
    }
}