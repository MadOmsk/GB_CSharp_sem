/*Программа удаляет вторую цифру случайно сгенерированного трёхзначного числа.*/
using EducationLibraries;

internal class Task11 : Task, IRunnableFromConsole
{
    private static string description = "Программа удаляет вторую цифру случайно сгенерированного трёхзначного числа.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        /*Случайное целое число в диапазоне[100, 999]*/
        int number = new Random().Next(100, 1000);
        Console.Write(number + " -> ");

        /*Эта конструкция превращает трёзначное число вида ABC в двухзначное вида AC*/
        number = (number / 100) * 10 + number % 10;

        Console.WriteLine(number);
    }
}