using System;

namespace RecursiveAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 500, 7, 1337, 228 };

            Console.WriteLine($"Max element array - {MaxElement(array)}");
        }

        static int MaxElement(int[] array, int i = 0)
        {
            if (array.Length - 1 != i)
            {
                int value = MaxElement(array, i + 1);
                if (array[i] < value)
                {
                    return value;
                }
            }
            return array[i];
        }
    }
}
