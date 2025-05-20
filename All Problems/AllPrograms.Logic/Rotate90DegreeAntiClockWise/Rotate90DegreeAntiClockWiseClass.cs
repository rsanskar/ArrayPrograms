namespace Rotate90DegreeAntiClockWise
{
    public class Rotate90DegreeAntiClockWiseClass
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
                    result[n - 1 - j][i] = array[i][j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i][j]+" ");
                }
                Console.WriteLine();
            }
        }

        public static void RotateArrayMethod2(int[][] array)
        {
            int n = array.Length;
            int m = array[0].Length;

            //transpse
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < m; j++)
                {
                    int temp = array[i][j];
                    array[i][j] = array[j][i];
                    array[j][i] = temp;
                }
            }

            //Reverse every column
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = array[j][i];
                    array[j][i] = array[n - j - 1][i];
                    array[n - j - 1][i] = temp;
                }
            }
            //Printing
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
