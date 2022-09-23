// Программа находит точку пересечения двух прямых.
using EducationLibraries;

internal class Task43 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит точку пересечения двух прямых.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var line1 = new Line(EdInputOutput.InputConsoleDouble("Введите коэффициенты k и b первой прямой через пробел", 2));
        var line2 = new Line(EdInputOutput.InputConsoleDouble("Введите коэффициенты k и b второй прямой через пробел", 2));

        System.Console.WriteLine($"Координаты точки пересечения: {Line.GetPointOfIntersection(line1, line2)}");
    }
}