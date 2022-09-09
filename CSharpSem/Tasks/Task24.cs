// Программа считает сумму чисел от 1 до А.
using EducationLibraries;

internal class Task24 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает сумму чисел от 1 до А.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInput.ConsoleInt("Введите натуральное число");

        System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {s_getSum(number)}");

    }
    private static int s_getSum(int input)
    {
        int result = 0;
        for (int i = 1; i <= input; i++)
        {
            result += i;
        }
        return result;
    }
}

