// Нахождение наибольшего числа из трёх.
using EducationLibraries;

internal class Task04 : Task, IRunnableFromConsole
{
    private static string description = "Нахождение наибольшего числа из трёх.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var numbers = new double[3];
        numbers[0] = EdInput.InputConsoleDouble("Введите первое число");
        numbers[1] = EdInput.InputConsoleDouble("Введите второе число");
        numbers[2] = EdInput.InputConsoleDouble("Введите третье число");

        // Cоздаём переменную max, присваиваем ему значение первого числа.
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
            if (max < numbers[i])
                max = numbers[i];
        Console.WriteLine($"Наибольшее число {max}");
    }
}
