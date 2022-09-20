// Заполняет двумерный массив по формуле A[i, j] = i + j.
using EducationLibraries;

internal class Task47 : Task, IRunnableFromConsole
{
    private static string description = "Заполняет двумерный массив по формуле A[i, j] = i + j.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int height = EdInputOutput.InputConsoleInteger("Введите количество строк:", Algebra.Sets.N);
        int width = EdInputOutput.InputConsoleInteger("Введите количество столбцов:", Algebra.Sets.N);

        var numbers = new int[height, width];

        FillTwoDemArray(numbers);
        Arrays.PrintTwoDemArray(numbers);
    }

    // Заполняет массив по формуле A[i, j] = i + j.
    private static void FillTwoDemArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = i + j;
    }
}