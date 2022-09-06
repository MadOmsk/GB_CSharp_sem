/*Программа выводит случайное число в диапазоне [10, 99] и показывает наибольшую цифру.*/
using EducationLibraries;

internal class Task09 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит случайное число в диапазоне [10, 99] и показывает наибольшую цифру.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = new Random().Next(10, 100);
        Console.WriteLine(number);
        int firstDigit = number / 10;
        int secondDigit = number % 10;

        if (firstDigit > secondDigit)
            Console.WriteLine(firstDigit);
        else
            Console.WriteLine(secondDigit);
    }
}
