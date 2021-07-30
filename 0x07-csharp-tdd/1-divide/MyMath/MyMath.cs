using System;

namespace MyMath
{
    /// <summary>public class Matrix</summary>
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
            {
                return null;
            }
            int[,] newMatrix;
            newMatrix = matrix;
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    newMatrix[i, j] /= num;
                }
            }
            return (newMatrix);
        }
    }
}
