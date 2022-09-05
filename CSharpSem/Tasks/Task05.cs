/*Вывод чисел от -N до N.*/
using EducationLibraries;

internal class Task05 : IRunnableFromConsole
{
    private static string description = "Вывод чисел от -N до N.";
    private static int numberOfTask = 5;
    internal static void Run()
    {
        Console.WriteLine(description);

        int number = EducationLibrary.ReadLineWithMessage("Введите число");

        for (int i = -number; i < number; i++)
        {
            Console.Write(i + ", ");
        }
        Console.Write(number);
    }
}