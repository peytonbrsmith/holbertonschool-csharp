using System;
using System.Linq;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (
            (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            ||
            (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3)
            )
        {
            double[,] err = new double[,] { { -1 } };
            err[0, 0] = -1;
            return err;
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
