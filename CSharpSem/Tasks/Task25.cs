// Возведение А в степень B.
using EducationLibraries;

internal class Task25 : Task, IRunnableFromConsole
{
    private static string description = "Возведение А в степень B.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        double baseOfExponentiation = EdInput.InputConsoleDouble("Введите число (основание)");
        int degree = (int)EdInput.InputConsoleInteger("Введите натуральное число (показатель)", Algebra.Sets.N);

        Console.WriteLine($"{baseOfExponentiation} в степени {degree} равно {s_pow(baseOfExponentiation, degree)}");
    }

    // Метод возводит число base в натуральную степень degree.
    private static double s_pow(double baseOfExponentiation, int degree)
    {
        double result = 1.0;
        for (int i = 0; i < degree; i++)
            result *= baseOfExponentiation;
        // Отбрасывает погрешность при вычислениях с double.
        result = Algebra.Softering(result);
        return result;
    }
}