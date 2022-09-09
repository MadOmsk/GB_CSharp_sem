// Программа считает сумму чисел от 1 до А.
using EducationLibraries;

internal class Task24 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает сумму чисел от 1 до А.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInput.ConsoleInt("Введите натуральное число");

        int[] cubes = new int[number];
        for (int i = 1; i <= number; i++)
        {
            cubes[i - 1] = i * i * i;
        }
        Console.WriteLine(String.Join(", ", cubes));
    }
}