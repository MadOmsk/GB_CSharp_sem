// Программа возвращает сумму цифр введённого числа (рекурсивно).
using EducationLibraries;

internal class Task67 : Task, IRunnableFromConsole
{
    private static string description = "Программа возвращает сумму цифр введённого числа (рекурсивно).";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInputOutput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        Console.WriteLine(GetNumbersSum(number));
    }

    // Возвращает сумму цифр.
    private static int GetNumbersSum(int number)
    {
        if (number == 0)
            return 0;
        // Возвращает сумму последней цифры числа и сумму цифр всех, кроме последней.
        return GetNumbersSum(number / 10) + number % 10;
    }
}