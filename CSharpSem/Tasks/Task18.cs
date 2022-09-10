// Программа по номеру четверти выдаёт диапазон координат X и Y.
using EducationLibraries;

internal class Task18 : Task, IRunnableFromConsole
{
    private static string description = "Программа по номеру четверти выдаёт диапазон координат X и Y.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int numberOfQuarter = (int)EdInput.InputConsoleInteger("Введите номер четверти", Algebra.Sets.N);

        string message;
        switch (numberOfQuarter)
        {
            case 1:
                message = "X > 0, Y > 0";
                break;
            case 2:
                message = "X < 0, Y > 0";
                break;
            case 3:
                message = "X < 0, Y < 0";
                break;
            case 4:
                message = "X > 0, Y < 0";
                break;
            default:
                message = "Нет такой четверти";
                break;
        }
        Console.WriteLine(message);
    }
}