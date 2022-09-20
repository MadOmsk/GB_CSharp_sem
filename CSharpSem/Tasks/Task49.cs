// Заменяет все элементы с чётными индексами (оба) двумерного массива их квадратами.
using EducationLibraries;

internal class Task49 : Task, IRunnableFromConsole
{
    private static string description = "Заменяет все элементы с чётными индексами (оба) двумерного массива их квадратами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int height = EdInputOutput.InputConsoleInteger("Введите количество строк:", Algebra.Sets.N);
        int width = EdInputOutput.InputConsoleInteger("Введите количество столбцов:", Algebra.Sets.N);

        var numbers = new int[height, width];
        Arrays.FillTwoDemArray(numbers, -9, 10);
        Arrays.PrintTwoDemArray(numbers);

        SquareEveryEvenElement(numbers);
        Console.WriteLine("_____________");
        Arrays.PrintTwoDemArray(numbers);

    }

    // Возводит в квадрат элементы с обоими чётными индексами.
    private static void SquareEveryEvenElement(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i += 2)
            for (int j = 0; j < array.GetLength(1); j += 2)
                array[i, j] = array[i, j] * array[i, j];
    }
}