/*Программа принимает на ввод номер дня недели и выводит является ли этот день выходным.*/
using EducationLibraries;

internal class Task15 : IRunnableFromConsole
{
    private static string description = "Программа принимает на ввод номер дня недели и выводит является ли этот день выходным.";
    private static int numberOfTask = 15;
    internal static void Run()
    {
        Console.WriteLine(description);

        int numberDayOfWeek = EducationLibrary.ReadLineWithMessage("Введите номер дня недели");

        switch (numberDayOfWeek)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Это будний день");
                break;
            case 6:
            case 7:
                Console.WriteLine("Это выходной");
                break;
            default:
                Console.WriteLine("Нет такого дня недели");
                break;
        }
    }
}
