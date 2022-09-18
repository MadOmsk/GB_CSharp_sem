// Здесь вся геометрия.

/// <summary>Класс точка, содержащий 2 координаты.</summary>
public class Point2D
{
    /// <summary>Координаты.</summary>
    public double X, Y;

    /// <summary>Создаёт объект по двум координатам.</summary>
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>Создаёт объект из массива double.</summary>
    public Point2D(double[] xy)
    {
        X = xy[0];
        Y = xy[1];
    }

    /// <summary>Расчитывает расстояние между двумя точками на декартовой плоскости, возвращает double.</summary>
    public static double CalculateDistance(Point2D a, Point2D b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}


/// <summary>Класс точка, содержащий 3 координаты.</summary>
public class Point3D
{
    /// <summary>Координаты.</summary>
    public double X, Y, Z;

    /// <summary>Создаёт объект по трём координатам.</summary>
    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>Создаёт объект из массива double.</summary>
    public Point3D(double[] xyz)
    {
        X = xyz[0];
        Y = xyz[1];
        Z = xyz[2];
    }

    /// <summary>Расчитывает расстояние между двумя точками на декартовом пространстве, возвращает double.</summary>
    public static double CalculateDistance(Point3D a, Point3D b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));
    }
}

/// <summary>Класс треугольник. Содержит статичные методы для проверки треугольника.</summary>
public class Triangle
{
    // Стороны.
    private double _a { get; }
    private double _b { get; }
    private double _c { get; }

    /// <summary>Создаёт треугольник по трём сторонам.
    /// Бросает ArgumentException, если треугольник с заданными сторонами не может существовать.</summary>
    private Triangle(double a, double b, double c)
    {
        if (!IsTriangleExist(a, b, c))
            throw new ArgumentException("Треугольник с заданными сторонами не может существовать");
        _a = a;
        _b = b;
        _c = c;
    }

    /// <summary>Создаёт треугольник по массиву sides со сторонами.
    /// Бросает ArgumentException, если треугольник с заданными сторонами не может существовать.</summary>
    private Triangle(double[] sides)
    {
        if (!IsTriangleExist(sides[0], sides[1], sides[2]))
            throw new ArgumentException("Треугольник с заданными сторонами не может существовать.");
        _a = sides[0];
        _b = sides[1];
        _c = sides[2];
    }

    /// <summary>Определяет является ли сумма чисел a и b больше, чем третье число longest.</summary>
    private static bool CompareTriangleSides(double a, double b, double longest)
    {
        return a + b > longest;
    }

    /// <summary>Определяет может ли существовать треугольник со сторонами a, b и c.
    /// Бросает ArgumentException, если треугольник с заданными сторонами не может существовать.</summary>
    public static bool IsTriangleExist(double a, double b, double c)
    {
        var sides = new double[] { a, b, c };
        return IsTriangleExist(sides);
    }

    /// <summary>Определяет может ли существовать треугольник со сторонами в массиве sides.
    /// Бросает ArgumentException, если треугольник с заданными сторонами не может существовать.</summary>
    public static bool IsTriangleExist(double[] sides)
    {
        if (!Polygon.IsSidesPositive(sides))
            throw new ArgumentException("Стороны треугольника не могут иметь отрицательную длину.");

        if (sides.Length != 3)
            throw new ArgumentException("Неверное число сторон.");

        return CompareTriangleSides(sides[0], sides[1], sides[2])
             && CompareTriangleSides(sides[1], sides[2], sides[0])
             && CompareTriangleSides(sides[2], sides[0], sides[1]);

    }

}

/// <summary>Класс многоугольник.</summary>
public class Polygon
{

    /// <summary>Проверяет являются ли стороны многоугольника положительными.</summary>
    public static bool IsSidesPositive(double[] sides)
    {
        for (int i = 0; i < sides.Length; i++)
        {
            if (sides[i] <= 0)
                return false;
        }
        return true;
    }

}