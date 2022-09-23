// Программа меняет строки на столбцы в двумерном массиве.
using EducationLibraries;

internal class Task55 : Task, IRunnableFromConsole
{
    private static string description = "Программа меняет строки на столбцы в двумерном массиве.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[4, 4];

        Arrays.FillTwoDemArray(array, 0, 10);

        Arrays.PrintTwoDemArray(array);

        Console.WriteLine("________________________________________________");

        try
        {
            ExchangeRowsColumns(array);
            Arrays.PrintTwoDemArray(array);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }


    }

    // Меняет местами строки и столбцы.
    private static void ExchangeRowsColumns(int[,] array)
    {
        if (array.GetLength(0) != array.GetLength(1))
            throw new FormatException("Количество строк не равно количеству столбцов");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                Algebra.Swap(ref array[j, i], ref array[i, j]);
            }
        }
    }
}