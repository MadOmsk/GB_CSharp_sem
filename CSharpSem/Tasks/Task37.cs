// Программа находит произведение противоположных элементов массива и помещает их в новый массив.
using EducationLibraries;

internal class Task37 : Task, IRunnableFromConsole
{
    private static string description = "Программа находит произведение противоположных элементов массива и помещает их в новый массив.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var numbers = new int[11];
        Arrays.FillArray(numbers, -10, 10);
        EdInputOutput.ConsolePrintWithSeparator(numbers);
        EdInputOutput.ConsolePrintWithSeparator(GetProduceOppisite(numbers));
        Console.WriteLine(String.Join(" ", GetProduceOppisite(numbers)));
    }

    // Возвращает массив, состоящий произведения противоположных элементов входящего массива
    private static int[] GetProduceOppisite(int[] array)
    {
        var produces = new int[(array.Length + 1) / 2];
        for (int i = 0; i < produces.Length; i++)
            produces[i] = array[i] * array[^(i + 1)];
        return produces;
    }
}