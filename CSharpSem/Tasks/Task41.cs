// Программа считает сколько чисел больше 0 ввёл пользователь с клавиатуры.
using EducationLibraries;

internal class Task41 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает сколько чисел больше 0 ввёл пользователь с клавиатуры.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        double[] numbers = EdInputOutput.InputConsoleDouble("Введите числа через пробел", -1);

        int count = 0;
        foreach (var i in numbers)
            if (i > 0)
                count++;

        Console.WriteLine($"Чисел больше 0 - {count} (всего {numbers.Length} чисел)");
    }
}