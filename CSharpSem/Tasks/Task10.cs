// Программа выводит вторую цифру трёхзначного числа.
using EducationLibraries;

internal class Task10 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит вторую цифру трёхзначного числа.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        bool quitCheck = true;
        while (quitCheck)
        {
            int number = EdInput.InputConsoleInteger("Введите трёхзначное число", Algebra.Sets.N);
            if (number <= 999 && number >= 100)
            {
                Console.Write(number + " -> ");
                // Определение второй цифры трёхзначного числа.
                number = (number / 10) % 10;
                Console.WriteLine(number);
                quitCheck = false;
            }
            else
                Console.WriteLine("Вы ввели не трёхзначное число");
        }
    }
}
