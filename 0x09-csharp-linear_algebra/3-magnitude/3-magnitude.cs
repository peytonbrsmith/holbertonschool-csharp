using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        int length = vector.Length;

        if (length == 2 || length == 3)
        {
            int magnitude = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                magnitude += (int)Math.Pow(vector[i], 2);
            }

            return (Math.Round(Math.Sqrt(magnitude), 2));
        }

        return (-1);
    }
}
