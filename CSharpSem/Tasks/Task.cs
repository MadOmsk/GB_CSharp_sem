using EducationLibraries;
/*Родительский класс для всех задач*/
internal abstract class Task : IRunnableFromConsole
{
    /*Хранит описание задачи.*/
    private static string description;
    /*Хранит номер задачи.*/
    private static int numberOfTask;
    /*Метод для запуска из консоли.*/
    internal static void Run() { }
    /*Получение значения description.*/
    internal static string getDescription() { return description; }
}