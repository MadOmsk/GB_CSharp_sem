namespace EducationLibraries;

// Алгебра
public static class Algebra
{
    // Множества чисел: N - натуральные, Z - целые, R - рациональные.
    public enum Sets { N, Z, Q };

    // Точность сравнения чисел.
    private static double precision = 1E-14;
    private static int precisionLog = (int)Math.Log(precision, 0.1);

    // Метод принимает на ввод double и set (член enum Sets - множества чисел) и возвращает принадлежность к этому set числа, сохранённого в double.
    public static bool SetOfNumber(double number, Sets set)
    {
        // Переменные, отображающие, является ли число натуральным, целым, рациональным, соответственно.
        bool isN = false, isZ = false, isQ = true;
        // Определяет целость числа с заданной точностью.
        if (Math.Abs((int)Softering(number) - number) < precision)
        {
            isZ = true;
            // Определяет натуральность числа.
            if (number > 0)
                isN = true;
        }

        // Выводит результат в зависимости от заданного множества
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

    // Преобразовывает рациональное число в целое. Если не получается, то бросает исключение.
    public static int RationalToInteger(double number)
    {
        if (SetOfNumber(number, Sets.Z))
            return (int)Softering(number);
        else throw new ArithmeticException("Число не является целым");
    }

    // Преобразовывает целое число в натуральное. Если не получается, то бросает исключение.
    public static int IntegerToNatural(int number)
    {
        if (SetOfNumber(number, Sets.N))
            return number;
        else throw new ArithmeticException("Число не является натуральным");
    }

    // Преобразовывает рациональное число в натуральное. Если не получается, то бросает исключение.
    public static int RationalToNatural(double number)
    {
        return IntegerToNatural(RationalToInteger(number));
    }

    // Отбрасывает погрешность, которая может образоваться при математических операциях с double.
    public static double Softering(double number)
    {
        return Math.Round(number, precisionLog, MidpointRounding.AwayFromZero);
    }
}

