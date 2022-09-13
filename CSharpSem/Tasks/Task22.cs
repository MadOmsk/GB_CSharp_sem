// Программа выводит таблицу квадратов от 1 до N.
using EducationLibraries;

internal class Task22 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит таблицу квадратов от 1 до N.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInputOutput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        int[] squares = new int[number];
        for (int i = 1; i <= number; i++)
        {
            squares[i - 1] = i * i;
        }
        Console.WriteLine(String.Join(", ", squares));
    }
}