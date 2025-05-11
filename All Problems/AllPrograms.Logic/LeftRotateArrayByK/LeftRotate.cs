namespace LeftRotateArrayByK
{
    public class LeftRotate
    {
        public static int[] RotateMethod1(int[] array, int k)
        {
            k = k%array.Length;
            int[] temp = new int[k];
            for(int i =0; i < k; i++)
            {
                temp[i] = array[i]; //move elements from 0 to k into temp array
            }
            for (int i = k;i<array.Length; i++)
            {
                array[i-k] = array[i]; //move elements from k to end from starting of an array
            }
            //int j = 0;
            //for(int i = array.Length-k; i< array.Length; i++)
            //{
            //    array[i] = temp[j];
            //    j++;
            //}
            for(int i =0; i < k; i++)
            {
                array[array.Length-k+i] = temp[i]; //append the temp elements at the last
            }
            return array;
        }

        public static int[] RotateMethod2(int[] array, int k)
        {
            k = k%array.Length;
            ReverseArray(array, 0, k-1);
            ReverseArray(array, k, array.Length-1);
            ReverseArray(array, 0, array.Length-1);

            return array;
        }

        private static int[] ReverseArray(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
            return array;
        }
    }
}
