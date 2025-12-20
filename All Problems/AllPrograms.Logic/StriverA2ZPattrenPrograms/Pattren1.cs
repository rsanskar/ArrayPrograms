namespace StriverA2ZPattrenPrograms
{
    public class Pattern1
    {
        public static void PrintPatteren1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }

    }
}
