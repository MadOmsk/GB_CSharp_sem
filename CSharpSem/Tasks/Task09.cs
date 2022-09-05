
using EducationLibraries;

internal class Task09 : IRunnableFromConsole
{
    private static string description = " .";
    private static int numberOfTask = 9;
    internal static void Run()
    {
        Console.WriteLine(description);
        
        int number = new Random().Next(10, 100);
        Console.WriteLine(number);
        int firstDigit = number / 10;
        int secondDigit = number % 10;

        if (firstDigit > secondDigit)
        {
            Console.WriteLine(firstDigit);
        }
        else
        {
            Console.WriteLine(secondDigit);
        }
    }
}
