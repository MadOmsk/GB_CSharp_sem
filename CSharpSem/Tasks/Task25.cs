// Возведение А в степень B.
using EducationLibraries;

internal class Task25 : Task, IRunnableFromConsole
{
    private static string description = "Возведение А в степень B.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int baseOfExponentiation = EdInput.ConsoleInt("Введите натуральное число (основание)");
        int degree = EdInput.ConsoleInt("Введите натуральное число (показатель)");

        Console.WriteLine($"{baseOfExponentiation} в степени {degree} равно {s_pow(baseOfExponentiation, degree)}");
    }

    private static long s_pow(int baseOfExponentiation, int degree)
    {
        long result = 1;
        for (int i = 0; i < degree; i++)
            result *= baseOfExponentiation;
        return result;
    }
}