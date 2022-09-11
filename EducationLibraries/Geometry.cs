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
