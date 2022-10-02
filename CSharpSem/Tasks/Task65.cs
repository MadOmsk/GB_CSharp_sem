// Программа выводит ряд чисел в промежутке между двумя введёнными, по убыванию (рекурсивно).
using EducationLibraries;

internal class Task65 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит ряд чисел в промежутке между двумя введёнными, по убыванию (рекурсивно).";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int[] ranges = EdInputOutput.InputConsoleInteger("Введите диапазон чисел (через пробел)", 2, Algebra.Sets.Z);
        int rangeMin = Algebra.Min(ranges[0], ranges[1]);
        int rangeMax = Algebra.Max(ranges[0], ranges[1]);

        Console.WriteLine(GetNaturnalRow(rangeMin, rangeMax));
    }

    // Возвращает строку - ряд чисел в промежутке между min и max (по убыванию).
    private static string GetNaturnalRow(int rangeMin, int rangeMax)
    {
        if (rangeMax == rangeMin)
            return rangeMax.ToString();

        return rangeMax + ", " + GetNaturnalRow(rangeMin, rangeMax - 1);
    }
}