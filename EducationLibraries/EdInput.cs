namespace EducationLibraries;

public static class EdInput
{
    /// <summary>Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в массив double.
    /// message - сообщение для вывода.
    /// n - количество ожидаемых аргументов.
    /// separator - символ, который будет разделять аргументы.</summary>
    public static double[] InputConsoleDouble(string message, int n, char separator)
    {
        // Выводит сообщение.
        Console.WriteLine(message);

        // Бесконечный цикл, из которого выходит только если удалось преобразование строки в массив double.
        while (true)
        {
            try
            {
                double[] result = StringToDoubles(Console.ReadLine()!, n, separator);
                return result;
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
                Console.WriteLine(" Повторите ввод.");
            }
        }
    }

    /// <summary>Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в double.
    /// Вызывает метод InputConsoleDouble с n = 1.</summary>
    public static double InputConsoleDouble(string message)
    {
        return InputConsoleDouble(message, 1)[0];
    }

    /// <summary>Вызывает метод InputConsoleDouble с разделителем пробел.</summary>
    public static double[] InputConsoleDouble(string message, int n)
    {
        return InputConsoleDouble(message, n, ' ');
    }


    /// <summary>Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в целое или натуральное число (long).
    /// message - сообщение для вывода.
    /// set - множество: целые или натуральные числа.</summary>
    public static int[] InputConsoleInteger(string message, int n, char separator, Algebra.Sets set)
    {
        // Выводит сообщение.
        Console.WriteLine(message);

        // Бесконечный цикл, из которого выходит только если удалось преобразование строки в массив long.
        while (true)
        {
            try
            {
                int[] result = StringToIntegers(Console.ReadLine()!, n, separator, set);
                return result;
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
                Console.WriteLine(" Повторите ввод.");
            }
        }
    }

    /// <summary>Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в long.
    /// Вызывает метод InputConsoleInteger с n = 1.</summary>
    public static int InputConsoleInteger(string message, Algebra.Sets set)
    {
        return InputConsoleInteger(message, 1, set)[0];
    }

    /// <summary>Вызывает метод InputConsoleInteger с разделителем пробел.</summary>
    public static int[] InputConsoleInteger(string message, int n, Algebra.Sets set)
    {
        return InputConsoleInteger(message, n, ' ', set);
    }

    /// <summary>Метод преобразовывает строку, предположительно содержащую какие-то числа, 
    /// разделённые символом, в массив чисел. Если не выходит, то бросает исключение.
    /// input - строка для преобразования.
    /// n - ожидаемое число аргументов.
    /// separator - разделитель строки.</summary>
    public static double[] StringToDoubles(string input, int n, char separator)
    {
        // Делит строку на части.
        string[] inputSplitted = input.Split(separator);
        // Если длина массива разделённой строки не равна числу введённых аргументов, то кидает ошибку.
        if (inputSplitted.Length != n)
            throw new FormatException("Неверное число аргументов.");

        // Результат для вывода.
        var result = new double[n];
        // Переменная, показывающая удалось преобразование или нет.
        bool status = true;
        // Преобразовывает каждую часть строки в double. Если не получается, то бросает исключение.
        for (int i = 0; i < n; i++)
        {
            status = double.TryParse(inputSplitted[i], out result[i]);
            if (!status)
                throw new FormatException("В строке присутствует не число.");
        }
        return result;
    }

    /// <summary>Метод преобразовывает строку, предположительно содержащую какие-то числа, разделённые символом, в массив целых или натуральных чисел. 
    /// Если не выходит, то бросает исключение.
    /// input - строка для преобразования.
    /// n - ожидаемое число аргументов.
    /// separator - разделитель строки.
    /// set - множество: целые или натуральные числа.</summary>
    public static int[] StringToIntegers(string input, int n, char separator, Algebra.Sets set)
    {
        // Вызывает метод StringToDoubles с теми же параметрами, сохраняет результат во временый массив.
        double[] intemediateDoubles = StringToDoubles(input, n, separator);

        // Результат для вывода.
        var result = new int[n];
        // Переменная, которая показывает удалось преобразование или нет.
        bool status = true;
        // Пробует преобразовать каждый член intemediateDoubles в нужное число - элемент массива result.
        for (int i = 0; i < n; i++)
        {
            // Преобразовывает каждый член double в целое число. Если не получается, то бросает исключение.
            try
            {
                result[i] = Algebra.DoubleToInteger(intemediateDoubles[i], set);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                status = false;
            }
        }
        if (!status)
            throw new FormatException("Преобразование не удалось.");
        return result;
    }

    /// <summary>Метод ожидает нажатия кнопки Space пользователем.</summary>
    public static void PressSpaceToContinue()
    {
        Console.WriteLine("Нажмите Space, чтобы продолжить");
        while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
    }
}