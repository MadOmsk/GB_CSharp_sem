//Вывод последней цифры трёхзначного числа.
using EducationLibraries;

internal class Task07 : Task, IRunnableFromConsole
{
    private static string description = "Вывод последней цифры трёхзначного числа.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        bool quitCheck = true;
        while (quitCheck)
        {
            int number = EdInput.InputConsoleInteger("Введите трёхзначное число", Algebra.Sets.N);
            if (number <= 999 && number >= 100)
            {
                Console.WriteLine("Последняя цифра трёхзначного числа " + number + " - " + number % 10);
                quitCheck = false;
            }
            else
                Console.WriteLine("Ваше число не трёхзначное");
        }
    }
}