/*Нахождение наибольшего числа из трёх.*/
using EducationLibraries;

internal class Task04 : Task, IRunnableFromConsole
{
    private static string description = "Нахождение наибольшего числа из трёх.";
    private static int numberOfTask = 4;
    new internal static void Run()
    {
        Console.WriteLine(description);

        int[] numbers = new int[3];
        numbers[0] = EducationLibrary.ReadLineWithMessage("Введите первое число");
        numbers[1] = EducationLibrary.ReadLineWithMessage("Введите второе число");
        numbers[2] = EducationLibrary.ReadLineWithMessage("Введите третье число");

        int max = numbers[0]; //создаём переменную max, присваиваем ему значение первого числа
        for (int i = 1; i < numbers.Length; i++)
            if (max < numbers[i])
                max = numbers[i];
        Console.WriteLine($"Наибольшее число {max}");
    }
}
