/*Программа выводит третью цифру введённого числа или сообщает, что её нет.*/
using EducationLibraries;

internal class Task13 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит третью цифру введённого числа или сообщает, что её нет.";
    private static int numberOfTask = 13;
    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EducationLibrary.ReadLineWithMessage("Введите целое число");
        if (number > 99)
            Console.WriteLine($"Третья цифра числа {number} - {number.ToString().Substring(2, 1)}");
        else
            Console.WriteLine("У этого числа нет трёх разрядов");
    }
}