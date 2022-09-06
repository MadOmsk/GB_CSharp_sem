namespace EducationLibraries;

public static class EducationLibrary
{
    /*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в int*/
    public static int ConsoleInt(string message)
    {
        System.Console.WriteLine(message);
        int a = int.Parse(System.Console.ReadLine()!);
        return a;
    }
    /*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в ulong*/
    public static ulong ConsoleUlong(string message)
    {
        System.Console.WriteLine(message);
        ulong a = ulong.Parse(System.Console.ReadLine()!);
        return a;
    }

    public static void PressSpaceToContinue()
    {
        Console.WriteLine("Нажмите Space, чтобы продолжить");
        while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
    }

}