// Программа переворачивает одномерный массив.
using EducationLibraries;

internal class Task39 : Task, IRunnableFromConsole
{
    private static string description = "Программа переворачивает одномерный массив.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[] { 1, 2, 3, 4, 5 };

        EdInputOutput.ConsolePrintWithSeparator(array);

        ReverseIntArray(array);

        EdInputOutput.ConsolePrintWithSeparator(array);
    }

    // Переворачивает массив int.
    private static void ReverseIntArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            Algebra.Swap(ref array[i], ref array[^(i + 1)]);
        }
    }
}