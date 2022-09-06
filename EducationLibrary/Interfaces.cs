namespace EducationLibraries;

public interface IRunnableFromConsole
{
    /*Этот метод предприсывает классу возможность запускаться в консоли, читать строки из консоли, выводить сообщения на консоль.*/
    internal static void Run()
    {
        Console.WriteLine(description);

        EducationLibrary.PressSpaceToContinue();
    }
    /*Описание что делает класс, оно же выводится как сообщение перед выполнением.*/
    private static string? description { get; }
    /*Переменная, по которой можно запустить метод Run().*/
}