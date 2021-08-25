using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) != 2)
        {
            double[,] err = new double[,] { { -1 } };
            err[0, 0] = -1;
            return err;
        }

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);
        double[,] rotationMatrix = new double[2, 2];
        rotationMatrix[0, 0] = cos;
        rotationMatrix[0, 1] = -1 * sin;
        rotationMatrix[1, 0] = sin;
        rotationMatrix[1, 1] = cos;

        double[,] rotatedMatrix = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    rotatedMatrix[i, j] = Math.Round(matrix[i, j] * rotationMatrix[0, j] + matrix[i, 1] * rotationMatrix[0, 1], 2);
                }
                if (j == 1)
                {
                    rotatedMatrix[i, j] = Math.Round(matrix[i, j] * rotationMatrix[1, j] + matrix[i, j - 1] * rotationMatrix[1, 0], 2);
                }
            }
        }

        return rotatedMatrix;
    }
}
