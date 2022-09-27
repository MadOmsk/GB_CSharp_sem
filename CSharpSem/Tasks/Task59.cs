// Программа удаляет строку и столбец с минимальным элементом двумерного массива.
using EducationLibraries;

internal class Task59 : Task, IRunnableFromConsole
{
    private static string description = "Программа удаляет строку и столбец с минимальным элементом двумерного массива.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[4, 4];
        Arrays.FillTwoDemArray(array, 0, 10);
        Arrays.PrintTwoDemArray(array);

        Console.WriteLine("________________________________________________");





    }

    // Находит минимальный элемент в массиве int.
    private static Tuple<int, int> FindMin(int[,] array)
    {
        int min = array[0, 0];
        // Координаты минимального элемента.
        Tuple<int, int> coordinates = Tuple.Create(0, 0);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                    min = array[i, j];
                coordinates = Tuple.Create(i, j);
            }
        }
        return coordinates;
    }

    // Удаляет строку в массиве и возвращает новый массив
    private static int[,] DeleteRow(int[,] array, int row)
    {
        var result = new int[array.GetLength(0) - 1, array.GetLength(1)];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(0); j++)
            {
                
            }
        }
        return result;
    }
}


