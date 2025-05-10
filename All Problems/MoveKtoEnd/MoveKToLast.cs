using System.Diagnostics;

namespace MoveKtoEnd
{
    public class MoveKToLast
    {
        public static void MoveElements(int[] array, int k)
        {
            int n = array.Length;
            int left = -1;
            for (int i = 0; i < n; i++)
            {
                if(array[i] == k)
                {
                    left = i;
                    break;
                }
            }
            for (int i = left + 1; i < n; i++)
            {
                if (array[i] != k)
                {
                    int temp = array[left];
                    array[left] = array[i];
                    array[i] = temp;
                    left++;
                }
            }
        }

    }
}
