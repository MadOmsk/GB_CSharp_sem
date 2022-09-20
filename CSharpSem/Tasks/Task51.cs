// Находит сумму элементов на главной диагонали.
using EducationLibraries;

internal class Task51 : Task, IRunnableFromConsole
{
    private static string description = "Находит сумму элементов на главной диагонали.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int height = EdInputOutput.InputConsoleInteger("Введите количество строк:", Algebra.Sets.N);
        int width = EdInputOutput.InputConsoleInteger("Введите количество столбцов:", Algebra.Sets.N);

        var numbers = new int[height, width];
        Arrays.FillTwoDemArray(numbers, -9, 10);
        Arrays.PrintTwoDemArray(numbers);
        Console.WriteLine($"Сумма элементов главной диагонали равна {GetMainDiagonalSum(numbers)}");
    }

    // Находит сумму элементов на главной диагонали.
    private static int GetMainDiagonalSum(int[,] array)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];
        return sum;
    }
}