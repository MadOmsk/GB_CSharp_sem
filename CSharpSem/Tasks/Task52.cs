// Программа считает среднее арифметическое каждого столбца в двумерном массиве.
using EducationLibraries;

internal class Task52 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает среднее арифметическое каждого столбца в двумерном массиве.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var numbers = new int[4, 3];

        Arrays.FillTwoDemArray(numbers, -9, 10);
        Arrays.PrintTwoDemArray(numbers);

        System.Console.Write("Среднее арифметическое столбцов массива: ");
        EdInputOutput.ConsolePrintWithSeparator(GetAveragesByColumns(numbers), ", ");

    }

    // Считает среднее арифметическое столбцов в массиве.
    private static double[] GetAveragesByColumns(int[,] array)
    {
        var averages = new double[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            averages[i] = 0;
            for (int j = 0; j < array.GetLength(0); j++)
                averages[i] += array[j, i];
            averages[i] /= array.GetLength(0);
        }
        return averages;
    }
}