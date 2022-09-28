// Программа формирует трёхмерный массив из неповторяющихся двузначных чисел и выводит его построчно с индексами.
using EducationLibraries;

internal class Task60 : Task, IRunnableFromConsole
{
    private static string description = "Программа формирует трёхмерный массив из неповторяющихся двузначных чисел и выводит его построчно с индексами.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        int[] dimentions = EdInputOutput.InputConsoleInteger("Введите размеры массива (через пробел)", 3, Algebra.Sets.N);

        var array3D = new int[dimentions[0], dimentions[1], dimentions[2]];

        try
        {
            Fill3DArray(array3D, 10, 100);
            Print3DArray(array3D);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    // Заполняет трёхмерный массив неповторяющимися элементами в диапазоне от min до max (не включая).
    // Бросает исключение, если невозможно заполнить неповторяющимися элементами в этом диапазоне.
    private static int[,,] Fill3DArray(int[,,] array, int min, int max)
    {
        if (array.Length > max - min)
            throw new Exception("Невозможно заполнить массив неповторяющимися элементами в этом диапазоне");

        var dictionary = new List<int>();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    int randomValue;

                    // Сохраняет в переменную randomValue случайное число, пока не найдёт число, которое не содержится в листе dictionary.
                    do
                        randomValue = new Random().Next(min, max);
                    while (dictionary.Contains(randomValue));

                    // Добаваляет randomValue в dictionary и сохраняет его в [i,j,k]-ячейку массива
                    dictionary.Add(randomValue);
                    array[i, j, k] = randomValue;
                }
            }
        }
        return array;
    }

    // Выводит трёхмерный массив построчно с индексами.
    private static void Print3DArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                for (int k = 0; k < array.GetLength(2); k++)
                    Console.WriteLine($"[{i}, {j}, {k}] = {array[i, j, k]}");
    }
}