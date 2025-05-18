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

        //public static void SetZerosMethod1(int[][] matrix)           //Not Giving Correct output
        //{
        //    int rowCount = matrix.Length;
        //    int colCount = 0;

        //    // Find the max column length (since it's a jagged array)
        //    foreach (var newrow in matrix)
        //    {
        //        if (newrow.Length > colCount)
        //            colCount = newrow.Length;
        //    }

        //    int[] row = new int[rowCount];
        //    int[] col = new int[colCount];
        //    for (int rows = 0; rows < matrix.Length; rows++)
        //    {
        //        for (int cols = 0; cols < matrix[rows].Length; cols++)
        //        {
        //            if (matrix[rows][cols] == 0)
        //            {
        //                row[rows] = 1;
        //                col[cols] = 1;
        //            }
        //        }
        //    }
        //    // Second pass: Set rows to zero based on markers
        //    for (int rows = 0; rows < rowCount; rows++)
        //    {
        //        if (row[rows] == 1)
        //        {
        //            for (int cols = 0; cols < matrix[rows].Length; cols++)
        //            {
        //                matrix[rows][cols] = 0;
        //            }
        //        }
        //    }

        //    // Second pass: Set columns to zero based on markers
        //    for (int cols = 0; cols < colCount; cols++)
        //    {
        //        if (col[cols] == 1)
        //        {
        //            for (int rows = 0; rows < rowCount; rows++)
        //            {
        //                if (cols < matrix[rows].Length) // Only zero out if column exists in the row
        //                {
        //                    matrix[rows][cols] = 0;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
