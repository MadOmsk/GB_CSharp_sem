// Вывод дней недели по номеру.
using EducationLibraries;

internal class Task03 : Task, IRunnableFromConsole
{
    private static string description = "Вывод дней недели по номеру.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        bool quitCheck = true;
        while (quitCheck)
        {
            int numberOfDay = EdInputOutput.InputConsoleInteger("Введите номер дня недели", Algebra.Sets.N);
            quitCheck = false;
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
                    quitCheck = true;
                    break;
            }
        }
    }
}