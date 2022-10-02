// Возвращает число возведённое в натуральную степень (рекурсивно).
using EducationLibraries;

internal class Task69 : Task, IRunnableFromConsole
{
    private static string description = "Возвращает число возведённое в натуральную степень (рекурсивно).";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int @base = EdInputOutput.InputConsoleInteger("Введите основание (целое число)", Algebra.Sets.Z);
        int degree = EdInputOutput.InputConsoleInteger("Введите показатель (целое положительное число)", Algebra.Sets.Z);

        Console.WriteLine($"{@base} ^ {degree} = {Pow(@base, degree)}");
    }

    // Возведение в степень (рекурсивно).
    private static int Pow(int @base, int degree)
    {
        if (degree == 0)
            return 1;

        return Pow(@base, degree - 1) * @base;
    }
}