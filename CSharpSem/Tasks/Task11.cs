/*Программа удаляет вторую цифру случайно сгенерированного трёхзначного числа.*/

using EducationLibraries;

internal class Task11 : IRunnableFromConsole
{
    private static string description = "Программа удаляет вторую цифру случайно сгенерированного трёхзначного числа.";
    private static int numberOfTask = 11;
    internal static void Run()
    {
        Console.WriteLine(description);

        int number = new Random().Next(100, 1000);
        Console.Write(number + " -> ");

        number = (number / 100) * 10 + number % 10;

        Console.WriteLine(number);
    }
}