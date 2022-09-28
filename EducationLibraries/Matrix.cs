namespace EducationLibraries;

public static class Matrix
{
    /// <summary>Производит умножение двух матриц (int).
    /// Если матрицы не могут быть перемножены, то бросает исключение</summary>
    public static int[,] MatrixDivision(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            throw new FormatException("Невозможно произвести умножение этих матриц.");

        var result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}