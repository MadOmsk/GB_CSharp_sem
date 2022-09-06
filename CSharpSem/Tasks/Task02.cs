/*Сравнение двух чисел.*/
using EducationLibraries;

internal class Task02 : Task, IRunnableFromConsole
{
    private static string description = "Сравнение двух чисел.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int firstNumber = EducationLibrary.ConsoleInt("Введите первое число");
        int secondNumber = EducationLibrary.ConsoleInt("Введите второе число");

        if (firstNumber > secondNumber)//сравниваем числа и выводим результат
            Console.WriteLine(firstNumber + " > " + secondNumber);
        else if (firstNumber < secondNumber)
            Console.WriteLine(firstNumber + " < " + secondNumber);
        else
            Console.WriteLine(firstNumber + " = " + secondNumber);
    }
}