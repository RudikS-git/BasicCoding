namespace Solution.IZ04_02_RecursiveAlgorithm
{
    static public class RecursiveAlgorithm
    {
        static public int FindMax(int[] array, int i = 0)
        {
            if (array.Length - 1 != i)
            {
                int value = FindMax(array, i + 1);
                if (array[i] < value)
                {
                    return value;
                }
            }
            return array[i];
        }
    }
}
