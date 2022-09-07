// Программа сообщает является ли одно введённое число квадратом другого.
using EducationLibraries;

internal class Task16 : Task, IRunnableFromConsole
{
    private static string description = "Программа сообщает является ли одно введённое число квадратом другого.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number1 = EdInput.ConsoleInt("Введите целое число");
        int number2 = EdInput.ConsoleInt("Введите целое число");

        // Сообщение для вывода.
        string message = "";
        if (number1 == number2 * number2)
            message = $"Число {number1} является квадратом числа {number2}";
        else if (number2 == number1 * number1)
            message = $"Число {number2} является квадратом числа {number1}";
        else
            message = $"Числа {number1} и {number2} не являются квадратами друг друга";
        Console.WriteLine(message);
    }
}
