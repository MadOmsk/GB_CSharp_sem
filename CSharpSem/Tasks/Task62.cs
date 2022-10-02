// Заполняет спирально массив с заданными координатами.
using EducationLibraries;

internal class Task62 : Task, IRunnableFromConsole
{
    private static string description = "Заполняет спирально массив с заданными координатами";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int[] size = EdInputOutput.InputConsoleInteger("Введите размер массива (через пробел)", 2, Algebra.Sets.N);

        int[,] array = new int[size[0], size[1]];

        Arrays.PrintTwoDemArray(FillArraySpiral(array));
    }

    private static void TestCell(bool[,] supportArray, int i, int j, int direction)
    {
        Tuple<int, int> cell = Tuple.Create(i, j);
        Tuple<int, int> nextCell = GetNextCell(direction, cell);
        bool isNextFilled = IsNextFilled(supportArray, direction, cell);
        bool isNearestFilled = IsNearestFilled(supportArray, cell);
        Console.WriteLine($"[{cell.Item1}, {cell.Item2}], direction: {direction} -> next: [{nextCell.Item1}, {nextCell.Item2}], filled: {isNextFilled}, nearest: {isNearestFilled}");
    }

    // Заполняет массив спирально.
    private static int[,] FillArraySpiral(int[,] array)
    {
        // Направление заполнения. 0 - вправо, 1 - вниз, 2, - влево, 3 - вверх.
        int direction = 0;
        // Начальная точка.
        Tuple<int, int> coordinates = Tuple.Create(0, 0);

        // Массив размера на 2 строки и столбца больше, каждый элемент которого хранит значение, заполнен ли аналогичный элемент основного массива.
        bool[,] supportArray = CreateSupportArray(array);
        // Заполняет первую ячейку.
        FillCurrentCell(array, supportArray, coordinates, 1);

        for (int i = 0; i < array.Length - 1; i++)
        {
            // Если следующая ячейка по направлению заполнена, то меняет направление.
            while (IsNextFilled(supportArray, direction, coordinates))
                ChangeDirection(ref direction);
            // Переставляет координаты на следующую ячейку по направлению.
            coordinates = GetNextCell(direction, coordinates);
            // Заполняет текущую ячейку.
            FillCurrentCell(array, supportArray, coordinates, i + 2);
        }

        return array;
    }

    // Создаёт и заполняет вспомогательный массив.
    private static bool[,] CreateSupportArray(int[,] array)
    {
        bool[,] supportArray = new bool[array.GetLength(0) + 2, array.GetLength(1) + 2];
        for (int i = 0; i < supportArray.GetLength(0); i++)
        {
            for (int j = 0; j < supportArray.GetLength(1); j++)
                supportArray[i, j] = i == 0 || j == 0 || i == supportArray.GetLength(0) - 1 || j == supportArray.GetLength(1) - 1;
        }
        return supportArray;
    }

    // Определяет заполнен ли следующий элемент (по направлению). coordinates - координаты из основного массива.
    private static bool IsNextFilled(bool[,] supportArray, int direction, Tuple<int, int> coordinates)
    {
        Tuple<int, int> nextCell = GetNextCell(direction, coordinates);
        return supportArray[nextCell.Item1 + 1, nextCell.Item2 + 1];
    }

    // Возвращает координаты следующей ячейки (по направлению).
    private static Tuple<int, int> GetNextCell(int direction, Tuple<int, int> coordinates)
    {
        switch (direction)
        {
            case 0:
                return Tuple.Create(coordinates.Item1, coordinates.Item2 + 1);
            case 1:
                return Tuple.Create(coordinates.Item1 + 1, coordinates.Item2);
            case 2:
                return Tuple.Create(coordinates.Item1, coordinates.Item2 - 1);
            case 3:
                return Tuple.Create(coordinates.Item1 - 1, coordinates.Item2);
            default:
                return null;
        }
    }

    // Проверяет являются ли все соседние элементы заданного массива заполненными.
    private static bool IsNearestFilled(bool[,] supportArray, Tuple<int, int> coordinates)
    {
        bool isNearestFilled = true;
        // Проверяет все направления. Если хотя бы одно false, то isNearestFilled станет false.
        for (int i = 0; i < 4; i++)
            isNearestFilled = isNearestFilled && IsNextFilled(supportArray, i, coordinates);

        return isNearestFilled;
    }

    // Изменяет направление по кругу (0 -> 1 -> 2 -> 3 -> 0).
    private static void ChangeDirection(ref int direction)
    {
        if (direction < 3)
            direction++;
        else
            direction = 0;
    }

    // Заполняет текущую ячейку.
    private static void FillCurrentCell(int[,] array, bool[,] supportArray, Tuple<int, int> coordinates, int value)
    {
        array[coordinates.Item1, coordinates.Item2] = value;
        supportArray[coordinates.Item1 + 1, coordinates.Item2 + 1] = true;
    }
}