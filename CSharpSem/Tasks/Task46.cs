// Программа заполняет двумерный массив случайными числами.
using EducationLibraries;

internal class Task46 : Task, IRunnableFromConsole
{
    private static string description = "Программа заполняет двумерный массив случайными числами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int height = EdInputOutput.InputConsoleInteger("Введите количество строк:", Algebra.Sets.N);
        int width = EdInputOutput.InputConsoleInteger("Введите количество столбцов:", Algebra.Sets.N);

        var numbers = new int[height, width];

        Arrays.FillTwoDemArray(numbers, -9, 10);
        Arrays.PrintTwoDemArray(numbers);
    }


}