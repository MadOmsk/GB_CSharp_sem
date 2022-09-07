namespace EducationLibraries;

// Алгебра
public static class Algebra
{
    // Множества чисел: N - натуральные, Z - целые, R - рациональные.
    public enum Sets { N, Z, R };

    // Точность сравнения чисел.
    private static double precision = 1E-14;

    // Метод принимает на ввод double и set (член enum Sets - множества чисел) и возвращает принадлежность к этому set числа, сохранённого в double.
    public static bool SetOfNumber(double number, Sets set)
    {
        // Переменные, отображающие, является ли число натуральным, целым, рациональным, соответственно.
        bool isN = false, isZ = false, isR = true;
        // Определяет целость числа с заданной точностью.
        if (Math.Abs((double)(int)number - number) < precision)
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
            case Sets.R:
                return isR;
            default:
                return false;
        }
    }

    // public static void 
}