// Программа считает сумму положительных и сумму отрицательных элементов массива из 12 элементов, заполненных случайными числами из промежутка [-9,9].
using EducationLibraries;

internal class Task31 : Task, IRunnableFromConsole
{
    private static string description = "Программа считает сумму положительных и сумму отрицательных элементов массива из 12 элементов, заполненных случайными числами из промежутка [-9,9].";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var numbers = new int[12];
        Arrays.FillArray(numbers, -9, 10);

        // Вывод результата
        Console.WriteLine(String.Join(" ", numbers));
        Console.WriteLine($"Сумма положительных элементов равна {GetPositiveSum(numbers)}");
        Console.WriteLine($"Сумма отрицательных элементов равна {GetNegativeSum(numbers)}");

    }


  // Нахождение суммы положительных элементов
    private static int GetPositiveSum (int[] array){
        
      int result = 0;
        foreach (var number in array)
        {
            if (number > 0)
                result += number;
        }
        return result;
    }

      //  // Нахождение суммы отрицательных элементов
    private static int GetNegativeSum (int[] array){
        
      int result = 0;
        foreach (var number in array)
        {
            if (number < 0)
                result += number;
        }
        return result;
    }
}