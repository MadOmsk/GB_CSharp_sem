// Программа выводит массив из 8 элементов, заполненный случайными нулями или единицами.
using EducationLibraries;

internal class Task30 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит массив из 8 элементов, заполненный случайными нулями или единицами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        Console.WriteLine(String.Join(", ", GetRandomArray(8)));
    }

    /// <summary>Метод создаёт массив заданной длины, заполненный случайными нулями или единицами.</summary>
    private static int[] GetRandomArray(int length)
    {
        var array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(0, 2);
        }
        return array;
    }
}