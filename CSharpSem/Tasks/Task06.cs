/*Определение чётности числа.*/
using EducationLibraries;

internal class Task06 : Task, IRunnableFromConsole
{
    private static string description = "Определение чётности числа.";
    private static int numberOfTask = 6;
    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EducationLibrary.ReadLineWithMessage("Введите целое число");

        /*Считаем остаток от деления на 2 и выводим результат.*/
        if (number % 2 == 0) //
            Console.WriteLine($"Число {number} - чётное");
        else
            Console.WriteLine($"Число {number} - нечётное");
    }
}