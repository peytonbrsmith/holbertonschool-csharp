using System;

namespace MyMath
{
    /// <summary>
    /// matrix class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// divide matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num"></param>
        /// <returns> divided matrix </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
            {
                return null;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }
            return result;
        }
    }
}
