namespace SpiralTraversalofMatrix
{
    public class SpiralTraversalofMatrixClass
    {
        public static void PrintSpiralMatrix(int[][] array)
        {
            int Left = 0, right = array[0].Length - 1;
            int bottom = array.Length - 1, top = 0;
            while (Left <= right && top <= bottom)
            {
                //Right
                for (int i = Left; i <= right; i++)
                {
                    Console.Write(array[top][i] + " ");
                }
                top++;

                //bottom
                for (int i = top; i <= bottom; i++)
                {
                    Console.Write(array[i][right] + " ");
                }
                right--;

                //left
                if (top <= bottom)
                {
                    for (int i = right; i >= Left; i--)
                    {
                        Console.Write(array[bottom][i] + " ");

                    }
                    bottom--;
                }

                //Top
                if (Left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        Console.Write(array[i][Left] + " ");
                    }
                }
                Left++;
            }
        }
    }
}
