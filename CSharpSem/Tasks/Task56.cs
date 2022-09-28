// Программа находит в двумерном массиве строку с наименьшей суммой элементов.
using EducationLibraries;

internal class Task56 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит в двумерном массиве строку с наименьшей суммой элементов.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[5, 5];

        Arrays.FillTwoDemArray(array, 0, 30);

        Arrays.PrintTwoDemArray(array);

        int indexRowWithMinSum = GetRowWithMinSum(array, out int sum);

        Console.WriteLine($"Индекс строки с минимальной суммой элементов - {indexRowWithMinSum} (сумма равна {sum})");
    }

    // Находит сумму элементов заданной строки двумерного массива.
    private static int GetRowSum(int[,] array, int row)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
            sum += array[row, i];

        return sum;
    }

    // Находит строку с минимальной суммой элементов в двумерном массиве. В переменную sum выводит эту сумму.
    private static int GetRowWithMinSum(int[,] array, out int sum)
    {
        int minSum = GetRowSum(array, 0);
        int indexRowWithMinSum = 0;
        for (int i = 1; i < array.GetLength(0); i++)
        {
            if (GetRowSum(array, i) < minSum)
            {
                minSum = GetRowSum(array, i);
                indexRowWithMinSum = i;
            }
        }
        sum = minSum;
        return indexRowWithMinSum;
    }
}