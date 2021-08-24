using System;

class VectorMath {
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[vector.Length];

        if ((vector.Length == 2 || vector.Length == 3))
        {
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = vector[i] * scalar;
            }
            return result;
        }
        double[] err = new double[1];
        err[0] = -1;
        return err;
    }
}
