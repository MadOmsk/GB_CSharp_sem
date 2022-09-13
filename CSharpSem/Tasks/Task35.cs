// Программа находит количество элементов массива из 123 элементов, лежащих в промежутке [10, 99].
using EducationLibraries;

internal class Task35 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит количество элементов массива из 123 элементов, лежащих в промежутке [10, 99].";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var numbers = new int[123];
        Arrays.FillArray(numbers, -100, 200);
        EdInputOutput.ConsolePrintWithSeparator(numbers);
        System.Console.WriteLine($"Этот массив содержит {s_findNumbersInRange(numbers, 10, 99)} чисел в промежутке от 10 до 99");
    }

    // Возвращает количество элементов массива в промежутке между minRangeValue и maxRangeValue (обе границы включает)
    private static int s_findNumbersInRange(int[] array, int minRangeValue, int maxRangeValue)
    {
        int count = 0;
        //for (int i = 0; i < array.Length; i++)
        foreach (var item in array)
            if (item >= minRangeValue && item <= maxRangeValue)
                count++;
        return count;
    }
}