// Программа определяет присутствует ли заданное число в массиве.
using EducationLibraries;

internal class Task33 : Task, IRunnableFromConsole
{
    private static string description = "Программа определяет присутствует ли заданное число в массиве.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var numbers = new int[12];
        Arrays.FillArray(numbers, -10, 10);
        EdInputOutput.ConsolePrintWithSeparator(numbers);

        int number = EdInputOutput.InputConsoleInteger($"Введите целое число", Algebra.Sets.Z);

        if (s_isContainsNumber(numbers, number))
            Console.WriteLine($"Массив содержит число {number}");
        else
            Console.WriteLine($"Массив НЕ содержит число {number}");
    }

    // Определяет содержится ли элемент в массиве
    private static bool s_isContainsNumber(int[] array, int number)
    {
        foreach (var item in array)
            if (item == number)
                return true;
        return false;
    }
}