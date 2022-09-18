// Программа считает произведение чисел от 1 до А (факториал).
using EducationLibraries;

internal class Task28 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает произведение чисел от 1 до А (факториал).";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInputOutput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        System.Console.WriteLine($"Произведение чисел от 1 до {number} равно {GetFactorial(number)}");
    }

    // Считает факториал.
    private static long GetFactorial(int input)
    {
        long result = 1;
        for (int i = 1; i <= input; i++)
        {
            result *= i;
        }
        return result;
    }
}