/*Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.*/
using EducationLibraries;

internal class Task12 : IRunnableFromConsole
{
    private static string description = "Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому.";
    private static int numberOfTask = 12;
    internal static void Run()
    {
        Console.WriteLine(description);

        int dividend = ReadLineWithMessage("Введите целое число (делимое)");
        int dividor = ReadLineWithMessage("Введите целое число (делитель)");

        int remainder = dividend % dividor; //остаток от деления
        if (remainder == 0)
            Console.WriteLine($"{dividend} кратно {dividor}");
        else
            Console.WriteLine($"Остаток от деления {dividend} на {dividor} равен {remainder}");

        /*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в int*/
        int ReadLineWithMessage(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}