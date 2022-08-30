using System;

Console.WriteLine("Введите номер дня недели");
string input = Console.ReadLine();
int numberOfDay = int.Parse(input);

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