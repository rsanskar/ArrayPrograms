namespace SetMatrixZeroes
{
    public class SetMatrixWithZeroes
    {
        public static void SetZeroes(int[][] matrix)
        {
            const int MARKER = -9999999;
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    if (matrix[rows][cols] == 0)
                    {
                        for (int j = 0; j < matrix[rows].Length; j++)
                        {
                            if (matrix[rows][j] != 0)
                            {
                                matrix[rows][j] = MARKER;
                            }
                        }
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            if (matrix[i][cols] != 0)
                            {
                                matrix[i][cols] = MARKER;
                            }

                        }
                    }
                }
            }
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    if (matrix[rows][cols] == MARKER)
                    {
                        matrix[rows][cols] = 0;
                    }
                }
            }
        }

        public static void SetZerosMethod1(int[][] matrix)           //Better solution
        {
            int[] colArray = new int[matrix[0].Length];
            int[] rowArray = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        colArray[j] = 1;
                        rowArray[i] = 1;
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (colArray[j] == 1 || rowArray[i] == 1)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            //Printing matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }



        }

        public static void SetZerosMethod2(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            //int[] colArray = new int[matrix[0].Length]; -->matrix[0][..]
            //int[] rowArray = new int[matrix.Length];    -->matrix[..][0]
            int col0 = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        // mark the i th row
                        matrix[0][j] = 0;
                        // mark the i th row
                        if (j != 0)
                        {
                            matrix[i][0] = 0;
                        }
                        else
                        {
                            col0 = 0;
                        }
                    }
                }
            }
            for(int i  = 1; i < n; i++)
            {
                for(int j = 1;j < m; j++)
                {
                    if((matrix[i][0] == 0 || matrix[0][j] == 0)){
                        matrix[i][j] = 0;
                    }
                }
            }
            if (matrix[0][0] == 0)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[0][j] = 0;
                }
            }
            if (col0 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i][0] = 0;
                }
            }
            //Printing matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
