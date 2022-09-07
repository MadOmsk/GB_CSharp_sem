// Вывод чисел от -N до N.
using EducationLibraries;

internal class Task05 : Task, IRunnableFromConsole
{
    private static string description = "Вывод чисел от -N до N.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInput.ConsoleInt("Введите число");

        for (int i = -number; i < number; i++)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine(number);
    }
}