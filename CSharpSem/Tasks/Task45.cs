// Программа копирует одномерный массив целых чисел.
using EducationLibraries;

internal class Task45 : Task, IRunnableFromConsole
{
    private static string description = "Программа копирует одномерный массив целых чисел.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[10];

        Arrays.FillArray(array, 0, 100);

        EdInputOutput.ConsolePrintWithSeparator(array);

        EdInputOutput.ConsolePrintWithSeparator(Arrays.CopyArrayInt(array));
    }


}