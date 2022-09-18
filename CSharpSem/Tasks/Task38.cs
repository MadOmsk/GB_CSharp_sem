// Программа находит разницу между максимальным и минимальным элементов массива вещественных чисел.
using EducationLibraries;

internal class Task38 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит разницу между максимальным и минимальным элементов массива вещественных чисел.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new double[10];
        Arrays.FillArray(array, -10, 10);

        EdInputOutput.ConsolePrintWithSeparator(array);

        System.Console.WriteLine($"Разница между максимальным и минимальным значением массива равна {SubstractMinFromMax(array)}");
    }

    // Находит разницу между максимальным и минимальным значением массива.
    private static double SubstractMinFromMax(double[] array)
    {
        return Arrays.FindMax(array) - Arrays.FindMin(array);
    }
}