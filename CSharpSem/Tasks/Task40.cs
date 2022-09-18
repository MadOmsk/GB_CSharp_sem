// Программа проверяет может ли существовать треугольник с заданными сторонами.
using EducationLibraries;

internal class Task40 : Task, IRunnableFromConsole
{
    private static string description = "Программа проверяет может ли существовать треугольник с заданными сторонами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        double[] sides = EdInputOutput.InputConsoleDouble("Введите длины сторон треугольника через пробел", 3);

        // Ловит исключения, которые может бросать метод IsTriangleExist.
        try
        {
            if (Triangle.IsTriangleExist(sides))
                Console.WriteLine($"Треугольник со сторонами {sides[0]}, {sides[1]}, {sides[2]} существует");
            else
                Console.WriteLine($"Треугольник со сторонами {sides[0]}, {sides[1]}, {sides[2]} НЕ существует");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }


    }
}
