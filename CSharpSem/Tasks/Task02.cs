// Сравнение двух чисел.
using EducationLibraries;

internal class Task02 : Task, IRunnableFromConsole
{
    private static string description = "Сравнение двух чисел.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int firstNumber = EdInput.ConsoleInt("Введите первое число");
        int secondNumber = EdInput.ConsoleInt("Введите второе число");

        if (firstNumber > secondNumber)//сравниваем числа и выводим результат
            Console.WriteLine(firstNumber + " > " + secondNumber);
        else if (firstNumber < secondNumber)
            Console.WriteLine(firstNumber + " < " + secondNumber);
        else
            Console.WriteLine(firstNumber + " = " + secondNumber);
    }
}