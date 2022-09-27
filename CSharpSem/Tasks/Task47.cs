// Программа заполняет двумерный массив размером m*n случайными вещественными числами.
using EducationLibraries;

internal class Task47 : Task, IRunnableFromConsole
{
    private static string description = "Заполняет двумерный массив размером m*n случайными вещественными числами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int height = EdInputOutput.InputConsoleInteger("Введите количество строк:", Algebra.Sets.N);
        int width = EdInputOutput.InputConsoleInteger("Введите количество столбцов:", Algebra.Sets.N);

        var numbers = new double[height, width];

        Arrays.FillTwoDemArray(numbers, -0.5, 0.1);
        Arrays.PrintTwoDemArray(numbers);
    }
}


