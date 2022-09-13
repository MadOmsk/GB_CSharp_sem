namespace EducationLibraries;

// Массивы
public static class Arrays
{

    // Заполнить массив int случайными элементами в диапазоне (max не включая)
    public static int[] FillArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(min, max);
        return array;
    }



}