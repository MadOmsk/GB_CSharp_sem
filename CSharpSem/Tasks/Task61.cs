// Программа выводит первые N строк треугольника Паскаля.
using EducationLibraries;

internal class Task61 : Task, IRunnableFromConsole
{
    private static string description = "Программа выводит первые N строк треугольника Паскаля.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int row = EdInputOutput.InputConsoleInteger("Введите количество строк треугольника Паскаля, которые нужно вывести", Algebra.Sets.N);

        int[][] triangle = PascalsTriangle(row);
        PrintPascalsTriangle(triangle);

    }

    // Создаёт массив с элементами: треугольник Паскаля. row - количество элементов.
    private static int[][] PascalsTriangle(int row)
    {
        int[][] triangle = new int[row][];
        triangle[0] = new int[1];
        triangle[0][0] = 1;
        triangle[1] = new int[2];
        triangle[1][0] = 1;
        triangle[1][1] = 1;
        for (int i = 2; i < row; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;
            for (int j = 1; j < triangle[i].Length - 1; j++)
            {
                //System.Console.WriteLine($"{i}, {j}, {triangle[i].Length}");
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }
        //System.Console.WriteLine(triangle.Length);
        return triangle;
    }

    // Печатает треугольник паскаля.
    private static void PrintPascalsTriangle(int[][] triangle)
    {
        int length = triangle.Length;
        for (int i = 0; i < triangle.Length; i++)
        {
            Console.Write(string.Concat(Enumerable.Repeat(" ", 2 * length - 2 - 2 * i)));
            for (int j = 0; j < triangle[i].Length; j++)
            {
                Console.Write(triangle[i][j]);
                Console.Write("   ");
            }
            Console.WriteLine();
        }
    }
}