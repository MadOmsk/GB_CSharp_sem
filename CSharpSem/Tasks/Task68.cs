// Программа вычисляет значение функции Аккермана (рекурсивно).
using EducationLibraries;

internal class Task68 : Task, IRunnableFromConsole
{
    private static string description = "Программа вычисляет значение функции Аккермана (рекурсивно).";

    new internal static void Run()
    {
        Console.WriteLine(description);
        int[] numbers = EdInputOutput.InputConsoleInteger("Введите аргументы для вычисления функции Аккермана (неотрицательные целые числа) (через пробел)", 2, Algebra.Sets.Z);

        PrintAckermann(numbers[0], numbers[1]);
    }

    // Выводит на экран значение функции Аккермана.
    private static void PrintAckermann(int arg1, int arg2)
    {
        try
        {
            Console.WriteLine($"Ackermann function for {arg1} and {arg2} = {CalculateAckermannFunc(arg1, arg2)}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    // Возвращает значение функции Аккермана для arg1 и arg2.
    private static int CalculateAckermannFunc(int arg1, int arg2)
    {
        if (arg1 < 0 || arg2 < 0)
            throw new ArgumentOutOfRangeException("Аргументы функции Аккермана должны быть неотрицательными");

        if (arg1 == 0)
            return arg2 + 1;
        else if (arg1 > 0 && arg2 == 0)
            return CalculateAckermannFunc(arg1 - 1, 1);
        else
            return CalculateAckermannFunc(arg1 - 1, CalculateAckermannFunc(arg1, arg2 - 1));
    }
}