using System;

class MatrixMath{
    public static double Determinant(double[,] matrix)
    {
        if(matrix.GetLength(1) == 2)
        {
            return Math.Round((matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1,0]), 2);
        }
        else if (matrix.GetLength(1) == 3)
        {
            double  det = 0;

            for(int i=0;i<3;i++)
                det = det + (matrix[0,i]*(matrix[1,(i+1)%3]*matrix[2,(i+2)%3] - matrix[1,(i+2)%3]*matrix[2,(i+1)%3]));
            return Math.Round(det, 2);
        }

        return -1;
    }
}
