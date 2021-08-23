using System;

class VectorMath {
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];

        if (vector1.Length != vector2.Length )
            return new double[-1];
        if (vector1.Length == 2 || vector2.Length == 3)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }
            return result;
        }

        return new double[-1];
    }
}
