// Здесь вся геометрия.

/// <summary>Класс точка, содержащий 2 координаты.</summary>
public class Point2D
{
    /// <summary>Координаты.</summary>
    public double _x { get; set; }
    public double _y { get; set; }

    /// <summary>Создаёт объект по двум координатам.</summary>
    public Point2D(double x, double y)
    {
        _x = x;
        _y = y;
    }

    /// <summary>Создаёт объект из массива double.</summary>
    public Point2D(double[] xy)
    {
        _x = xy[0];
        _y = xy[1];
    }

    /// <summary>Расчитывает расстояние между двумя точками на декартовой плоскости, возвращает double.</summary>
    public static double CalculateDistance(Point2D a, Point2D b)
    {
        return Math.Sqrt(Math.Pow(b._x - a._x, 2) + Math.Pow(b._y - a._y, 2));
    }

    override public string ToString()
    {
        return $"({_x}; {_y})";
    }
}


/// <summary>Класс точка, содержащий 3 координаты.</summary>
public class Point3D
{
    /// <summary>Координаты.</summary>
    public double _x { get; set; }
    public double _y { get; set; }
    public double _z { get; set; }

    /// <summary>Создаёт объект по трём координатам.</summary>
    public Point3D(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    /// <summary>Создаёт объект из массива double.</summary>
    public Point3D(double[] xyz)
    {
        _x = xyz[0];
        _y = xyz[1];
        _z = xyz[2];
    }

    /// <summary>Расчитывает расстояние между двумя точками на декартовом пространстве, возвращает double.</summary>
    public static double CalculateDistance(Point3D a, Point3D b)
    {
        return Math.Sqrt(Math.Pow(b._x - a._x, 2) + Math.Pow(b._y - a._y, 2) + Math.Pow(b._z - a._z, 2));
    }

    override public string ToString()
    {
        return $"({_x}; {_y}, {_z})";
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

/// <summary>Класс линия на плоскости.</summary>
public class Line
{
    // Коэффициент наклона k (y = k * x + b).
    private double _k { get; }
    // Коэффициент смещения b (y = k * x + b).
    private double _b { get; }

    /// <summary>Создаёт линию из двух чисел k и b.</summary>
    public Line(double k, double b)
    {
        _k = k;
        _b = b;
    }

    /// <summary>Создаёт линию из массива из двух чисел k и b.</summary>
    public Line(double[] kb)
    {
        _k = kb[0];
        _b = kb[1];
    }

    // Точка пересечения двух прямых.
    public static Point2D GetPointOfIntersection(Line line1, Line line2)
    {
        double x = (line2._b - line1._b) / (line1._k - line2._k);
        double y = (line1._k * line2._b - line2._k * line1._b) / (line1._k - line2._k);
        return new Point2D(x, y);
    }
}