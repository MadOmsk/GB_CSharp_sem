// Программа преобразовывает натуральное десятичное число в двоичное.
using EducationLibraries;

internal class Task42 : Task, IRunnableFromConsole
{
    private static string description = "Программа преобразовывает натуральное десятичное число в двоичное.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInputOutput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        Console.WriteLine(ConvertDecToBinary(number));
    }

    // Преобразование через цикл.
    private static string ConvertDecToBinary(int number)
    {
        string result = String.Empty;
        while (number > 0)
        {
            result = $"{number % 2}{result}";
            number /= 2;
        }
        return result;
    }

    // Через рекурсию. Не работает.
    private static string ConvertDecToBinaryRecursively(int number)
    {
        number /= 2;

        string result = $"{ConvertDecToBinaryRecursively(number % 2)}";
        if (number == 0) return result;
        return result;
    }
}