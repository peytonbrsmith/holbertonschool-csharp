using System;
using System.Linq;

class VectorMath {
    public static double DotProduct(double[] vector1, double[] vector2)

    {
        double result = 0;

        if (vector1.Length == vector2.Length && (vector1.Length == 2 || vector1.Length == 3))
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }
            return result;
        }
        return -1;
    }
}
class MatrixMath {
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)

    {
        double[,] result = new double[matrix2.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
