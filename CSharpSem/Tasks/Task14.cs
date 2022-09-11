// Программа сообщает кратно ли введённое число 7 и 23 одновременно.
using EducationLibraries;

internal class Task14 : Task, IRunnableFromConsole
{
    private static string description = "Программа сообщает кратно ли введённое число 7 и 23 одновременно.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        // 7 * 23 = 161.
        if (number % 7 == 0 && number % 23 == 0)
            Console.WriteLine($"Число {number} кратно 7 и 23");
        else
            Console.WriteLine($"Число {number} НЕ кратно 7 и 23");
    }
}