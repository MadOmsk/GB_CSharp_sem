// Программа составляет частотный словарь двумерного массива.
using EducationLibraries;

internal class Task57 : Task, IRunnableFromConsole
{
    private static string description = "Программа составляет частотный словарь двумерного массива.";

    new internal static void Run()
    {
        Console.WriteLine(description);

        var array = new int[4, 4];
        Arrays.FillTwoDemArray(array, -9, 1);
        Arrays.PrintTwoDemArray(array);

        Console.WriteLine("________________________________________________");

        int[] array1d = Arrays.Convert2DArrayTo1D(array);

        PrintDictionary(GetDictionary(array1d));
    }

    // Создаёт словарь элементов массива array.
    private static List<ElementFrequency> GetDictionary(int[] array)
    {
        // Создаёт словарь (пустой).
        var dictionary = new List<ElementFrequency>();
        for (int i = 0; i < array.Length; i++)
        {
            // Ищет в dictionary элемент array[i,j].
            int index = GetIndexInList(dictionary, array[i]);
            // Если нашёл элемент, то увеличивает частоту на 1.
            if (index != -1)
                dictionary[index].Frequency++;
            // Если не нашёл элемент, то добавляет его в dictionary с частотой 1.
            else
                dictionary.Add(new ElementFrequency(array[i]));
        }
        return dictionary;
    }

    // Метод ищет элемент в dictionary. 
    // Если находит, то возвращает его индекс в словаре, если не находит, то возвращает -1.
    private static int GetIndexInList(List<ElementFrequency> dictionary, int element)
    {
        for (int i = 0; i < dictionary.Count; i++)
        {
            // Если находит элемент возвращает его номер в словаре.
            if (element == dictionary[i].Element)
                return i;
        }
        // Если элемент не найден, то возвращает -1.
        return -1;
    }

    // Печатает словарь построчно.
    private static void PrintDictionary(List<ElementFrequency> dictionary)
    {
        foreach (var item in dictionary)
            Console.WriteLine(item);
    }
}

// Класс частоты использования элемента.
// Содержит поля: сам элемент и его частота использования.
internal class ElementFrequency
{
    // Элемент.
    public int Element { get; set; }
    // Частота использования элемента.
    public int Frequency { get; set; }

    // Стандартный конструктор.
    public ElementFrequency(int element, int frequency)
    {
        Element = element;
        Frequency = frequency;
    }

    // Новый элемент, ранее не встречавшийся, создаётся с Frequency 1.
    public ElementFrequency(int element)
    {
        Element = element;
        Frequency = 1;
    }

    // Переопределение метода ToString().
    public override string ToString()
    {
        return $"{Element} встречается {Frequency} раз.";
    }
}