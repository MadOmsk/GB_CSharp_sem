// Программа показывает количество чётных чисел в массиве со случайными трёхзначными числами.
using EducationLibraries;

internal class Task34 : Task, IRunnableFromConsole
{
    private static string description = "Программа показывает количество чётных чисел в массиве со случайными трёхзначными числами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[10];
        Arrays.FillArray(array, 100, 1000);

        EdInputOutput.ConsolePrintWithSeparator(array);

        Console.WriteLine($"Количество чётных элементов в массиве равно {CountEvens(array)}");

    }

    // Считает количество чётных элементов в массиве int.
    private static int CountEvens(int[] array)
    {
        int count = 0;
        foreach (var item in array)
        {
            if (item % 2 == 0)
                count++;
        }
        return count;
    }
}