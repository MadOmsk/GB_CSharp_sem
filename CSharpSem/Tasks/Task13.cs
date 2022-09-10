// Программа выводит третью цифру введённого числа или сообщает, что её нет.
using EducationLibraries;

internal class Task13 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит третью цифру введённого числа или сообщает, что её нет.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        long number = EdInput.InputConsoleInteger("Введите натуральное число (делимое)", Algebra.Sets.N);

        if (number > 99)
        {
            // Это выражение преобразовывает число в строку, затем из этой строки присваивает 3 символ переменной thirdDigit.
            char thirdDigit = number.ToString()[2];
            Console.WriteLine($"Третья цифра числа {number} - {thirdDigit}");
        }
        else
            Console.WriteLine("У этого числа нет трёх разрядов");
    }
}