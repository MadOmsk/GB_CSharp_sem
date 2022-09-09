// Программа считает сумму цифр в числе.
using EducationLibraries;

internal class Task27 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает сумму цифр в числе.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInput.ConsoleInt("Введите натуральное число");

        Console.WriteLine($"Сумма цифр числа {number} равна {s_sumOfArray(s_getDigits(number))}");
    }

    // Считает количество разрядов числа.
    private static int s_getDepth(int number)
    {
        int depth = 0;
        while (number > 0)
        {
            number /= 10;
            depth++;
        }
        return depth;
    }

    // Создаёт массив из цифр числа.
    private static int[] s_getDigits(int number)
    {
        var digits = new int[s_getDepth(number)];
        for (int i = 0; i < digits.Length; i++)
        {
            int currentDigit = number % 10;
            number /= 10;
            digits[^(i + 1)] = currentDigit;
        }
        return digits;
    }

    // Считает сумму элементов массива.
    private static int s_sumOfArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];
        return sum;
    }
}