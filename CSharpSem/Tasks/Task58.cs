// .
using EducationLibraries;

internal class Task58 : Task, IRunnableFromConsole
{
    private static string description = ".";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var matrix1 = new int[5, 2];
        var matrix2 = new int[2, 3];

        Arrays.FillTwoDemArray(matrix1, -5, 5);
        Arrays.FillTwoDemArray(matrix2, -5, 5);

        Arrays.PrintTwoDemArray(matrix1);
        Console.WriteLine("______________________________________________________________");
        Arrays.PrintTwoDemArray(matrix2);
        Console.WriteLine("______________________________________________________________");

        try
        {
            int[,] resultMatrix = Matrix.MatrixDivision(matrix1, matrix2);
            Arrays.PrintTwoDemArray(resultMatrix);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}