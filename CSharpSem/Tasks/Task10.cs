/*Программа выводит вторую цифру трёхзначного числа.*/
using EducationLibraries;

internal class Task10 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит вторую цифру трёхзначного числа.";
    private static int numberOfTask = 10;
    new internal static void Run()
    {
        Console.WriteLine(description);

        int number = EducationLibrary.ReadLineWithMessage("Введите трёхзначное число");
        
        if (number < 1000 && number > 99)
        {
            Console.Write(number + " -> ");

            number = (number / 10) % 10;

            Console.WriteLine(number);
        }
        else
            Console.WriteLine("Вы ввели не трёхзначное число");
    }
}
