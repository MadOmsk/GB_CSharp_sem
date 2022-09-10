// Программа выводит таблицу кубов от 1 до N.
using EducationLibraries;

internal class Task23 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит таблицу кубов от 1 до N.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = (int)EdInput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        int[] cubes = new int[number];
        for (int i = 1; i <= number; i++)
        {
            cubes[i - 1] = i * i * i;
        }
        Console.WriteLine(String.Join(", ", cubes));
    }
}