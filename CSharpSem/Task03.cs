/*Вывод дней недели по номеру.*/
using EducationLibraries;

internal class Task03 : IRunnableFromConsole
{
    private static string description = "Вывод дней недели по номеру.";
    private static int numberOfTask = 3;
    internal static void Run()
    {
        Console.WriteLine(description);

        int numberOfDay = EducationLibrary.ReadLineWithMessage("Введите номер дня недели");

        switch (numberOfDay)
        {
            case 1:
                Console.WriteLine("Это понедельник");
                break;
            case 2:
                Console.WriteLine("Это вторник");
                break;
            case 3:
                Console.WriteLine("Это среда");
                break;
            case 4:
                Console.WriteLine("Это четверг");
                break;
            case 5:
                Console.WriteLine("Это пятница");
                break;
            case 6:
                Console.WriteLine("Это суббота");
                break;
            case 7:
                Console.WriteLine("Это воскресенье");
                break;
            default:
                Console.WriteLine("Нет такого дня недели!");
                break;
        }
    }
}