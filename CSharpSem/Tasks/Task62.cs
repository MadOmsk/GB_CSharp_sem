// Заполняет спирально массив 4x4. НЕ ЗАКОНЧЕНО.
using EducationLibraries;

internal class Task62 : Task, IRunnableFromConsole
{
    private static string description = "Заполняет спирально массив 4x4. НЕ ЗАКОНЧЕНО.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int[,] array = new int[4, 4];
    }

    // Заполняет массив спирально.
    // ПОКА НЕ РАБОТАЕТ.
    private static int[,] FillArraySpiral(int[,] array)
    {
        // Границы.
        int leftBorder = 0;
        int rightBorder = array.GetLength(1) - 1;
        int topBorder = 0;
        int bottomBorder = array.GetLength(0) - 1;
        // Направление заполнения. 0 - вправо, 1 - вниз, 2, - влево, 3 - вверх.
        int direction = 0;
        int count = 1;

        // Массив такого же размера, каждый элемент которого хранит значение, заполнен ли аналогичный элемент основного массива.
        bool[,] supportArray = new bool[array.GetLength(0), array.GetLength(1)];

        int i = 0;
        int j = 0;
        while (!isNearestFilled(supportArray, i, j))
        {

        }

        return null;
    }

    // Если соседний элемент у границы массива, то он заполнен слева. Если не у границы, то заполнение определяется по заполнению соседнего элементаю.
    private static bool isLeftFilled(bool[,] array, int i, int j)
    {
        bool left;
        if (j == 0)
            left = true;
        else
            left = array[i, j - 1];
        return left;
    }

    // Аналогично для правого элемента.
    private static bool isRightFilled(bool[,] array, int i, int j)
    {
        bool right;
        if (j == array.GetLength(1) - 1)
            right = true;
        else
            right = array[i, j + 1];
        return right;
    }

    // Аналогично для верхнего элемента.
    private static bool isTopFilled(bool[,] array, int i, int j)
    {
        bool top;
        if (i == 0)
            top = true;
        else
            top = array[i - 1, j];
        return top;
    }

    // Аналогично для нижнего элемента.
    private static bool isBottomFilled(bool[,] array, int i, int j)
    {
        bool bottom;
        if (i == array.GetLength(0) - 1)
            bottom = true;
        else
            bottom = array[i + 1, j];
        return bottom;
    }

    // Проверяет являются ли все соседние элементы заданного массива заполненными.
    private static bool isNearestFilled(bool[,] array, int i, int j)
    {
        // Переменные, в которых хранится состояние соседних элементов.
        bool left, right, top, bottom;

        left = isLeftFilled(array, i, j);
        right = isRightFilled(array, i, j);
        top = isTopFilled(array, i, j);
        bottom = isBottomFilled(array, i, j);

        return left && right && top && bottom;
    }

    // Изменяет направление по кругу (0 -> 1 -> 2 -> 3 -> 0).
    private static void ChangeDirection(ref int direction)
    {
        if (direction < 4)
            direction++;
        else
            direction = 0;
    }

    // НЕ РАБОТАЕТ.
    private static void GetNextIndexByDirection(int[,] array, ref int i, ref int j, int direction)
    {

    }

    // НЕ РАБОТАЕТ.
    private static void FillNext(int[,] array, bool[,] supportArray, int i, int j, int direction, int count)
    {

        switch (direction)
        {
            case 0:
                array[i, j + 1] = count;
                break;
            case 1:
                array[i + 1, j] = count;
                break;
            case 2:
                array[i, j - 1] = count;
                break;
            case 3:
                array[i - 1, j] = count;
                break;
            default:
                break;
        }


    }
}