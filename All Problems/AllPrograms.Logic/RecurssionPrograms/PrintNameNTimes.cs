namespace RecurssionPrograms
{
    public class PrintNameNTimes
    {
        public static void PrintName(string name,int n)
        {
            if(n<=0)
            {
                return;
            }
            Console.WriteLine(name);
            PrintName(name, n-1);
        }
    }
}
