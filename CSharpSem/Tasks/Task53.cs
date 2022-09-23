// Программа меняет местами первую и последнюю строку двумерного массива.
using EducationLibraries;

internal class Task53 : Task, IRunnableFromConsole
{
    private static string description = "Программа меняет местами первую и последнюю строку двумерного массива.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[5, 10];

        Arrays.FillTwoDemArray(array, 0, 10);

        Arrays.PrintTwoDemArray(array);

        Console.WriteLine("________________________________________________");

        ExchangeRows(array, 0, array.GetLength(0) - 1);

        Arrays.PrintTwoDemArray(array);
    }

    // Меняет местами строки row1 и row2.
    private static void ExchangeRows(int[,] array, int row1, int row2)
    {
        var tempRow = new int[array.GetLength(1)];
        for (int i = 0; i < tempRow.Length; i++)
        {
            tempRow[i] = array[row1, i];
            array[row1, i] = array[row2, i];
            array[row2, i] = tempRow[i];
        }
    }
}