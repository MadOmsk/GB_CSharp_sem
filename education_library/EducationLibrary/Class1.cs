namespace EducationLibrary;

public static class EducationLibrary
{
    /*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в int*/
    public static int ReadLineWithMessage(string message)
    {
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine()!);
    }
}