// Вывод чётных чисел от 1 до N.

using EducationLibraries;

internal class Task08 : Task, IRunnableFromConsole
{
    private static string description = "Вывод чётных чисел от 1 до N.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        // Принимает на ввод число.
        int number = EdInput.InputConsoleInteger("Введите натуральное число", Algebra.Sets.N);
  
        // Применение к числу метода generateEvenNumbers.
        int[] evens = s_generateEvenNumbers(number);

        //Вывод массива.
        Console.WriteLine(string.Join(", ", evens));
    }

    // Метод выводит чётные числа в промежутке от 0 до num.
    private static int[] s_generateEvenNumbers(int number)
    {
        // Генерация массива для вывода.
        // Создаёт массив чётных чисел.
        var evens = new int[number / 2];
        // Дополнительный индекс для внесения чисел в массив evens.
        int j = 0;
        // Проходит по циклу от 1 до числа.
        for (int i = 1; i <= number; i++)
        {
            // Проверяет чётность индекса цикла.
            if (i % 2 == 0)
            {
                // Вносит чётное число в массив evens.
                evens[j] = i;
                j++;
            }
        }
        return evens;
    }
}
