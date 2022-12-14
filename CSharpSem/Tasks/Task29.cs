// Пользователь вводит 8 чисел. Программа помещает их в массив и выводит на экран.
using EducationLibraries;

internal class Task29 : Task, IRunnableFromConsole
{
    private static string description = "Пользователь вводит 8 чисел. Программа помещает их в массив и выводит на экран.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[8];
        for (int i = 0; i < array.Length; i++)
            array[i] = EdInputOutput.InputConsoleInteger($"Введите натуральное число {i + 1}", Algebra.Sets.N);

        Console.WriteLine(String.Join(", ", array));
    }
}