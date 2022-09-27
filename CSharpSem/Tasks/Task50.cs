// Программа выводит из двумерного массива элемент с введённым индексом.
using EducationLibraries;

internal class Task50 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит из двумерного массива элемент с введённым индексом.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int[] index = EdInputOutput.InputConsoleInteger("Введите индекс элемента (через пробел):", 2, Algebra.Sets.N);

        int height = 5;
        int width = 4;
        var numbers = new double[height, width];

        Arrays.FillTwoDemArray(numbers, -0.5, 0.1);
        Arrays.PrintTwoDemArray(numbers);
        Console.WriteLine("_____________");

        if (index[0] <= height && index[1] <= width)
            Console.WriteLine($"Элемент с индексом [{index[0]}, {index[1]}] -> {numbers[index[0] - 1, index[1] - 1]:F3}");
        else
            Console.WriteLine("Элемента с заданным индексом не существует");
    }
}