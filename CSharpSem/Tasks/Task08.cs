// Вывод чётных чисел от 1 до N.

using EducationLibraries;

internal class Task08 : Task, IRunnableFromConsole
{
    // Делегат, работающий с int, выводит int[].
    private delegate int[] integerDelegate(int num);

    private static string description = "Вывод чётных чисел от 1 до N.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        // Просит пользователя ввести число.
        Console.WriteLine("Введите положительное целое число");
        // Ввод числа, преобразование в int.
        bool status = double.TryParse(Console.ReadLine(), out double inputNumber);

        // Проверка числа, применение к нему метода generateEvenNumbers.
        int[] evens = checkParsedValue(generateEvenNumbers, status, inputNumber);

        //Вывод массива.
        Console.WriteLine(string.Join(", ", evens));
    }

    // Метод проверяет является ли число целым положительным, преобразовывает его в int и выполняет необходимую операцию с этим числом, имеющую на выходе int[].
    // На входе bool и double - результат double.TryParse().
    private static int[] checkParsedValue(integerDelegate integerDelegate1, bool status, double inputNumber)
    {
        //Проверяет правильно ли спарсилась строка, выводит необходимое сообщение, если не получилось целое положительное число.
        try
        {
            // Проверка является ли строка числом.
            if (!status)
                throw new FormatException("Вы ввели не число");
            // Проверка является или число целым.
            else if ((Math.Abs((double)(int)inputNumber - inputNumber) > Double.Epsilon))
                throw new FormatException("Вы ввели дробное число");
            // Проверка, является ли число положительным.
            else if ((int)inputNumber <= 0)
                throw new FormatException("Вы ввели неположительное число");
            else
                // Преобразовывает введённое число в целое и выполняет с ним операцию.
                return integerDelegate1((int)inputNumber);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return new int[0];
    }

    // Метод выводит чётные числа в промежутке от 0 до num.
    private static int[] generateEvenNumbers(int number)
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
