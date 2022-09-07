// Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.
using EducationLibraries;

internal class Task12 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int dividend = EdInput.ConsoleInt("Введите целое число (делимое)");
        int dividor = EdInput.ConsoleInt("Введите целое число (делитель)");

        // Определение остатка от деления.
        int remainder = dividend % dividor;
        if (remainder == 0)
            Console.WriteLine($"{dividend} кратно {dividor}");
        else
            Console.WriteLine($"Остаток от деления {dividend} на {dividor} равен {remainder}");
    }
}