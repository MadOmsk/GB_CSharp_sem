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

    /// <summary>Заполнить массив double случайными элементами в диапазоне (max не включая).</summary>
    public static double[] FillArray(double[] array, double min, double max)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = (new Random().NextDouble()) * (max - min) + min;
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

    // Попробовать сделать копирования массива любого типа. Пока не работает
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


}