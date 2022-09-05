/*Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.*/
using EducationLibraries;

internal class Task12 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.";
    private static int numberOfTask = 12;
    new internal static void Run()
    {
        Console.WriteLine(description);

        int dividend = EducationLibrary.ReadLineWithMessage("Введите целое число (делимое)");
        int dividor = EducationLibrary.ReadLineWithMessage("Введите целое число (делитель)");

        int remainder = dividend % dividor; //остаток от деления
        if (remainder == 0)
            Console.WriteLine($"{dividend} кратно {dividor}");
        else
            Console.WriteLine($"Остаток от деления {dividend} на {dividor} равен {remainder}");
    }
}