// Сравнение двух чисел.
using EducationLibraries;

namespace Task1;

internal class Task02 : Task
{
    private static string description = "Сравнение двух чисел.";

    new internal void Run()
    {
        Console.WriteLine(description);

        double firstNumber = EdInput.InputConsoleDouble("Введите первое число");
        double secondNumber = EdInput.InputConsoleDouble("Введите второе число");

        // Сравнивает числа и выводит результат.
        if (firstNumber > secondNumber)
            Console.WriteLine(firstNumber + " > " + secondNumber);
        else if (firstNumber < secondNumber)
            Console.WriteLine(firstNumber + " < " + secondNumber);
        else
            Console.WriteLine(firstNumber + " = " + secondNumber);
    }
}