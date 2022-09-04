/*Определение, является ли первое число квадратом второго.*/
using EducationLibraries;

internal class Task01 : IRunnableFromConsole
{
    private static string description = "Определение, является ли первое число квадратом второго.";
    private static int numberOfTask = 1;
    internal static void Run()
    {
        Console.WriteLine(description);

        int firstNumber = EducationLibrary.ReadLineWithMessage("Введите первое число");
        int secondNumber = EducationLibrary.ReadLineWithMessage("Введите второе число");

        if (firstNumber == secondNumber * secondNumber)
            Console.WriteLine($"Число {firstNumber} является квадратом {secondNumber}");
        else
            Console.WriteLine($"Число {firstNumber} НЕ является квадратом {secondNumber}");
    }
    internal static string getDescription() { return description; }
}