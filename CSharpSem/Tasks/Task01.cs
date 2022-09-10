// Определение, является ли первое число квадратом второго.
using EducationLibraries;

internal class Task01 : Task, IRunnableFromConsole
{
    private static string description = "Определение, является ли первое число квадратом второго.";
    
    new internal static void Run()
    {
        Console.WriteLine(description);

        long firstNumber = EdInput.InputConsoleInteger("Введите первое число (целое)", Algebra.Sets.Z);
        long secondNumber = EdInput.InputConsoleInteger("Введите второе число (целое)", Algebra.Sets.Z);

        if (firstNumber == secondNumber * secondNumber)
            Console.WriteLine($"Число {firstNumber} является квадратом {secondNumber}");
        else
            Console.WriteLine($"Число {firstNumber} НЕ является квадратом {secondNumber}");
    }
}
