/*Программа выводит третью цифру введённого числа или сообщает, что её нет.*/
using EducationLibraries;

internal class Task13 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит третью цифру введённого числа или сообщает, что её нет.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        /*Поддерживает очень большие числа.*/
        ulong number = EducationLibrary.ConsoleUlong("Введите целое положительное число");
        if (number > 99)
        {
            /*Это выражение преобразовывает число в строку, затем из этой строки присваивает 3 символ переменной thirdDigit.*/
            string thirdDigit = number.ToString().Substring(2, 1);
            Console.WriteLine($"Третья цифра числа {number} - {thirdDigit}");
        }
        else
            Console.WriteLine("У этого числа нет трёх разрядов");
    }
}