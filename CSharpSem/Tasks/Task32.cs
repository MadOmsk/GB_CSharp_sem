// Программа заменяет отрицательные элементы массива на положительные и наоборот.
using EducationLibraries;

internal class Task32 : Task, IRunnableFromConsole
{
    private static string description = "Программа заменяет отрицательные элементы массива на положительные и наоборот.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var numbers = new int[10];

        Arrays.FillArray(numbers, -100, 100);
        EdInputOutput.ConsolePrintWithSeparator(numbers);

        s_reverse(numbers);
        EdInputOutput.ConsolePrintWithSeparator(numbers);
    }

    // Изменяет знак каждого элемента массива
    private static void s_reverse(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -array[i];
        }
    }
}