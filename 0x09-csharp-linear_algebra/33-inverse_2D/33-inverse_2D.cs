using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        if(matrix.GetLength(1) == 2 && matrix.GetLength(0) == 2)
        {
            return Math.Round((matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1,0]), 2);
        }
        else if (matrix.GetLength(1) == 3 && matrix.GetLength(0) == 3)
        {
            double  det = 0;

            for(int i=0;i<3;i++)
                det = det + (matrix[0,i]*(matrix[1,(i+1)%3]*matrix[2,(i+2)%3] - matrix[1,(i+2)%3]*matrix[2,(i+1)%3]));
            return Math.Round(det, 2);
        }

        return -1;
    }
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || Determinant(matrix) == 0)
        {
            double[,] err = new double[,] { { -1 } };
            return err;
        }

        double[,] inverse = new double[matrix.GetLength(0), matrix.GetLength(1)];
        inverse[0, 0] = Math.Round(matrix[1, 1] / (matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1]), 2);
        inverse[1, 1] = Math.Round(matrix[0, 0] / (matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1]), 2);
        inverse[1, 0] = Math.Round(-(matrix[1, 0] / (matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1])), 2);
        inverse[0, 1] = Math.Round(-(matrix[0, 1] / (matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1])), 2);

        return inverse;
    }
}
