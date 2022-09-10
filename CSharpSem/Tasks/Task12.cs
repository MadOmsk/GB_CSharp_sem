// Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.
using EducationLibraries;

internal class Task12 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        long dividend = EdInput.InputConsoleInteger("Введите натуральное число (делимое)", Algebra.Sets.N);
        long dividor = EdInput.InputConsoleInteger("Введите натуральное число (делимое)", Algebra.Sets.N);

        // Определение остатка от деления.
        long remainder = dividend % dividor;
        if (remainder == 0)
            Console.WriteLine($"{dividend} кратно {dividor}");
        else
            Console.WriteLine($"Остаток от деления {dividend} на {dividor} равен {remainder}");
    }
}