// Программа принимает на ввод номер дня недели и выводит является ли этот день выходным.
using EducationLibraries;

internal class Task15 : Task, IRunnableFromConsole
{
    private static string description = "Программа принимает на ввод номер дня недели и выводит является ли этот день выходным.";

    new internal static void Run()
    {
        Console.WriteLine(description);


        bool quitCheck = true;
        while (quitCheck)
        {
            int numberDayOfWeek = EdInputOutput.InputConsoleInteger("Введите номер дня недели", Algebra.Sets.N);
            quitCheck = false;

            // Сообщение для вывода после определения дня недели.
            string message = "";
            switch (numberDayOfWeek)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    message = "Это будний день";
                    break;
                case 6:
                case 7:
                    message = "Это выходной";
                    break;
                default:
                    message = "Нет такого дня недели";
                    quitCheck = true;
                    break;
            }
            Console.WriteLine(message);
        }
    }
}
