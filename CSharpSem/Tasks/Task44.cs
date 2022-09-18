// Выводит первые N чисел последовательности Фибоначчи.
using EducationLibraries;

internal class Task44 : Task, IRunnableFromConsole
{
    private static string description = "Выводит первые N чисел последовательности Фибоначчи.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EdInputOutput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);

        EdInputOutput.ConsolePrintWithSeparator(Fibonacci(number));
    }

    // Рассчитывает массив первых N элементов последовательности Фибоначчи.
    private static int[] Fibonacci(int number)
    {
        int[] result = new int[number];
        result[0] = 0;
        result[1] = 1;
        for (int i = 3; i <= number; i++)
            result[i - 1] = result[i - 2] + result[i - 3];
        return result;
    }
}