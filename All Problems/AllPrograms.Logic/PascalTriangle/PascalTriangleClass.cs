namespace PascalTriangle
{
    public class PascalTriangleClass
    {
        // Given row number r and column number c. Print the element at position (r, c) in Pascal’s triangle.
        public static void PascalTriangleType1(int R, int C)
        {
            Console.WriteLine();
            Console.WriteLine(funcNCr(R-1,C-1));
        }

        //Given the row number n.Print the n-th row of Pascal’s triangle.
        public static void PascalTriangleType2(int n)
        {
            int ans = 1;
            Console.Write(ans+" ");
            for (int i = 1; i <n ; i++)
            {
                ans = ans * (n - i);
                ans = ans / i;
                Console.Write(ans +" ");
            }
            Console.WriteLine();
        }

        public static void pascalTriangleType3Method1(int n)
        {
            for(int row = 1; row<= n; row++)
            {
                for(int col = 1; col<= row; col++)
                {
                    Console.Write(funcNCr(row-1,col-1));
                }
                Console.WriteLine();
            }
        }
        public static void pascalTriangleType3Method2(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PascalTriangleType2(row);
            }
        }
        private static int funcNCr(int n, int r)
        {
            int res = 1;
            for (int i = 0; i < r; i++)
            {
                res = res * (n - i);
                res = res / (i + 1);
            }

            return res;
        }

    }
}
