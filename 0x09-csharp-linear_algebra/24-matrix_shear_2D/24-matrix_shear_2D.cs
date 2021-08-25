using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) != 2 || (direction != 'x' && direction != 'y'))
        {
            double[,] err = new double[,] { { -1 } };
            err[0, 0] = -1;
            return err;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (direction == 'x')
            {
                result[i, 0] = matrix[i, 0] + matrix[i, 1] * factor;
                result[i, 1] = matrix[i, 1];
            }
            if (direction == 'y')
            {
                result[i, 1] = matrix[i, 1] + matrix[i, 0] * factor;
                result[i, 0] = matrix[i, 0];
            }
        }

        return result;
    }
}
