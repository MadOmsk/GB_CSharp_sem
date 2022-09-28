// Программа упорядочивает по убыванию элементы каждой строки двумерного массива.
using EducationLibraries;

internal class Task54 : Task, IRunnableFromConsole
{
    private static string description = "Программа упорядочивает по убыванию элементы каждой строки двумерного массива.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[5, 15];

        Arrays.FillTwoDemArray(array, 0, 30);

        Arrays.PrintTwoDemArray(array);

        Console.WriteLine("______________________________________________________________");

        SortEveryRowIn2DArray(array);

        Arrays.PrintTwoDemArray(array);
    }

    // Сортировка по убыванию (метод расчёсткой) указанной строки двумерного массива.
    private static void SortRowIn2DArrayByDesc(int[,] array, int row)
    {
        double factor = 1.2473309;
        double gapDouble = array.GetLength(1);
        int gap = (int)gapDouble - 1;
        while (gapDouble > 1)
        {
            gapDouble /= factor;
            gap = (int)Math.Ceiling(gapDouble) - 1;//round double distance to floor
            for (int j = gap; j < array.GetLength(1); j++)
            {
                if (array[row, j - gap] < array[row, j])
                {
                    int temp = array[row, j - gap];
                    array[row, j - gap] = array[row, j];
                    array[row, j] = temp;
                }
            }
        }
    }

    private static void SortEveryRowIn2DArray(int[,] array){
        for (int i = 0; i < array.GetLength(0); i++)
            SortRowIn2DArrayByDesc(array, i);
    }
}