

int numberDayOfWeek = ReadLineWithMessage("Введите номер дня недели");

switch (numberDayOfWeek)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Это будний день");
        break;
    case 6:
    case 7:
        Console.WriteLine("Это выходной");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}

/*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в int*/
int ReadLineWithMessage(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}