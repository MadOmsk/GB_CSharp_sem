using EducationLibraries;
// Родительский класс для всех задач

//namespace Task1;

internal abstract class Task : IRunnableFromConsole
{
    private static string description = "";


    internal void Run() { 
        System.Console.WriteLine(description);
    }
}