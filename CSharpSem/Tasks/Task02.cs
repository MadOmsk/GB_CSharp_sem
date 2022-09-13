// Сравнение двух чисел.
using EducationLibraries;

internal class Task02 : Task, IRunnableFromConsole
{
    private static string description = "Сравнение двух чисел.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        double firstNumber = EdInputOutput.InputConsoleDouble("Введите первое число");
        double secondNumber = EdInputOutput.InputConsoleDouble("Введите второе число");

        // Сравнивает числа и выводит результат.
        if (firstNumber > secondNumber)
            Console.WriteLine(firstNumber + " > " + secondNumber);
        else if (firstNumber < secondNumber)
            Console.WriteLine(firstNumber + " < " + secondNumber);
        else
            Console.WriteLine(firstNumber + " = " + secondNumber);
    }
}