// Заполняет массив случайными числами от 0 до 99. Находит максимальное и минимальное значение.
using EducationLibraries;

internal class TaskX01 : Task, IRunnableFromConsole
{
    private static string description = "Заполняет массив случайными числами от 0 до 99. Находит максимальное и минимальное значение.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[10];
        s_fillArray(array);

        Console.WriteLine(String.Join(", ", array));
        Console.WriteLine($"max = {s_maxOfArray(array)}");
        Console.WriteLine($"min = {s_minOfArray(array)}");
    }

    private static void s_fillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(0, 100);
    }

    private static int s_maxOfArray(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;
    }

    private static int s_minOfArray(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
        return min;
    }
}
