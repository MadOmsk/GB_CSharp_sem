namespace EducationLibraries;

// Алгебра
public static class Algebra
{
    /// <summary>Множества чисел: N - натуральные, Z - целые, R - рациональные.</summary>
    public enum Sets { N, Z, Q };

    // Точность сравнения чисел.
    private static double precision = 1E-14;
    private static int precisionLog = (int)Math.Log(precision, 0.1);

    /// <summary>Метод принимает на ввод double и set (член enum Sets - множества чисел) 
    /// и возвращает принадлежность к этому set числа, сохранённого в double.
    /// Не отбрасывает погрешность.</summary>
    public static bool SetOfNumber(double number, Sets set)
    {
        // Переменные, отображающие, является ли число натуральным, целым, рациональным, соответственно.
        bool isN = false, isZ = false, isQ = true;
        // Определяет целость числа с заданной точностью.
        if (Math.Abs((long)Softering(number) - number) < precision)
        {
            isZ = true;
            // Определяет натуральность числа.
            if (number > 0)
                isN = true;
        }

        // Выводит результат в зависимости от заданного множества.
        switch (set)
        {
            case Sets.N:
                return isN;
            case Sets.Z:
                return isZ;
            case Sets.Q:
                return isQ;
            default:
                return false;
        }
    }
    // УПРОСТИТЬ КОД
    /// <summary>Преобразовывает double в целое или натуральное число. Если не получается, то бросает исключение.
    /// number - число для преобразования.
    /// set - множество: целые или натуральные числа. Если указано недопустимое множество, то бросает исключение.
    /// Отбрасывает погрешность при вычислении с double.</summary>
    public static long DoubleToInteger(double number, Sets set)
    {
        // Проверка условия допустимого множества.
        if (set != Sets.N && set != Sets.Z)
        {
            System.Console.WriteLine(set);
            throw new Exception("Invalid set. Use valid set: Sets.Z or Sets.N");
        }

        // Проверка, соответствует ли число указанному множеству. 
        if (SetOfNumber(number, set))
            return (long)Softering(number);
        else if (set == Sets.N)
            throw new ArithmeticException("Число не является натуральным.");
        else if (set == Sets.Z)
            throw new ArithmeticException("Число не является целым.");
        else
            throw new Exception("Unknown error");
    }

    /// <summary>Отбрасывает погрешность, которая может образоваться при математических операциях с double.</summary>
    public static double Softering(double number)
    {
        return Math.Round(number, precisionLog, MidpointRounding.AwayFromZero);
    }
}

