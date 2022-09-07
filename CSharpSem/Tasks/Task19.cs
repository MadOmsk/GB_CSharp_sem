// Программа определяет является ли введённое пятизначное число палиндромом.
using EducationLibraries;

internal class Task19 : Task, IRunnableFromConsole
{
    private static string description = "Программа определяет является ли введённое пятизначное число палиндромом.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInput.ConsoleInt("Введите пятизначное число");

        if (number >= 10000 && number < 100000)
        {
            // Сравнивает 1 с 5 и 2 с 4 цифры числа.
            if (number.ToString()[0] == number.ToString()[4] && number.ToString()[1] == number.ToString()[3])
                Console.WriteLine("Это число - палиндром");
            else
                System.Console.WriteLine("Это число не палиндром");
        }
        else
            Console.WriteLine("Это не пятизначное число");
    }
}