// Программа находит сумму элементов, стоящих на нечётных позициях в одномерном массиве.
using EducationLibraries;

internal class Task36 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит сумму элементов, стоящих на нечётных позициях в одномерном массиве.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[6];
        Arrays.FillArray(array, -10, 10);

        EdInputOutput.ConsolePrintWithSeparator(array);

        Console.WriteLine($"Сумма элементов на нечётных местах равна {GetSumOdds(array)}");

    }

    // Считает сумму элементов массива на нечётных местах (первый элемент - чётный).
    private static int GetSumOdds(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
                sum += array[i];
        }
        return sum;
    }
}
