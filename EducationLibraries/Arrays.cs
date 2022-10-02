namespace EducationLibraries;

// Массивы
public static class Arrays
{

    /// <summary>Заполнить массив int случайными элементами в диапазоне (max не включая).</summary>
    public static int[] FillArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(min, max);
        return array;
    }

    /// <summary>Заполняет двумерный массив случайными int в диапазоне (max не включая).</summary>
    public static int[,] FillTwoDemArray(int[,] array, int min, int max)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = new Random().Next(min, max);
        }

        return array;
    }

    /// <summary>Заполняет двумерный массив случайными double в диапазоне (max не включая).</summary>
    public static double[,] FillTwoDemArray(double[,] array, double min, double max)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = new Random().NextDouble() * (max - min) + min;
        }

        return array;
    }

    /// <summary>Заполнить массив double случайными double в диапазоне (max не включая).</summary>
    public static double[] FillArray(double[] array, double min, double max)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().NextDouble() * (max - min) + min;
        return array;
    }

    /// <summary>Находит максимальное значение в массиве int.</summary>
    public static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }

    /// <summary>Находит минимальное значение в массиве int.</summary>
    public static int FindMin(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    /// <summary>Находит максимальное значение в массиве double.</summary>
    public static double FindMax(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }

    /// <summary>Находит минимальное значение в массиве double.</summary>
    public static double FindMin(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }


    /// <summary>Копирует массив int поэлементно.</summary>
    public static int[] CopyArrayInt(int[] array)
    {
        var copiesArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            copiesArray[i] = array[i];
        }
        return copiesArray;
    }

    // TODO: Попробовать сделать копирования массива любого типа. Пока не работает
    /// <summary>Копирует массив int поэлементно.</summary>
    public static Object[] CopyArray(Object[] array)
    {
        var copiesArray = new Object[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            copiesArray[i] = array[i];
        }
        return copiesArray;
    }


    // TODO: Ввести параметр depth - количество символов выводимого элемента
    /// <summary>Выводит на экран двумерный массив int.</summary>
    public static void PrintTwoDemArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j],4} ");
            Console.WriteLine();
        }
    }

    // TODO: Ввести параметр depth - количество символов выводимого элемента
    /// <summary>Выводит на экран двумерный массив double.</summary>
    public static void PrintTwoDemArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]:F3} ");
            Console.WriteLine();
        }
    }

    // TODO: Ввести параметр depth - количество символов выводимого элемента
    /// <summary>Выводит на экран двумерный массив double.</summary>
    public static void PrintTwoDemArray(bool[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]:F3} ");
            Console.WriteLine();
        }
    }

    // Преобразовывает двумерный массив int в одномерный массив int.
    public static int[] Convert2DArrayTo1D(int[,] array)
    {
        var result = new int[array.GetLength(0) * array.GetLength(1)];
        // Счётчик для конечного массива.
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[count] = array[i, j];
                count++;
            }
        }
        return result;
    }

    // Преобразовывает двумерный массив double в одномерный массив double.
    public static double[] Convert2DArrayTo1D(double[,] array)
    {
        var result = new double[array.GetLength(0) * array.GetLength(1)];
        // Счётчик для конечного массива.
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[count] = array[i, j];
                count++;
            }
        }
        return result;
    }
}