namespace Rotate90DegreeClockWise
{
    public class Rotate90DegreeClockWiseClass
    {
        public static void RotateArray(int[][] array)
        {
            int n = array.Length;
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n]; // Set column length for each row
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[j][n - 1 - i] = array[i][j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void RotateArrayMethod2(int[][] array)
        {
            int n = array.Length;
            int m = array[0].Length;

            //transpse
            for(int i = 0; i<n;i++)
            {
                for(int j = i; j< m; j++)
                {
                    int temp = array[i][j];
                    array[i][j] = array[j][i];
                    array[j][i] = temp;
                }
            }

            //Reverse every row
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n/2; j++)
                {
                    int temp = array[i][j];
                    array[i][j] = array[i][n - j - 1];
                    array[i][n - j - 1] = temp;
                }
            }
            //Printing
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
