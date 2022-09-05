/*Программа сообщает является ли одно введённое число квадратом другого*/
using EducationLibraries;
class Program
{
    static void Main(string[] args)
    {
        int number1 = EducationLibrary.ReadLineWithMessage("Введите целое число");
        int number2 = EducationLibrary.ReadLineWithMessage("Введите целое число");

        if (number1 == number2 * number2)
            Console.WriteLine($"Число {number1} является квадратом числа {number2}");
        else if (number2 == number1 * number1)
            Console.WriteLine($"Число {number2} является квадратом числа {number1}");
        else
            Console.WriteLine($"Числа {number1} и {number2} не являются квадратами друг друга");

    }
}

