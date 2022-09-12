using EducationLibraries;
// Родительский класс для всех задач
internal abstract class Task : IRunnableFromConsole
{
    private static string description = "";


    internal void Run() { 
        System.Console.WriteLine(description);
    }
}