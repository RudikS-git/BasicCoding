using System;

namespace SearchIndexElement
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 3.0, 5.0, 3.5, 6.0, 11.6 };

            Console.WriteLine($"Индекс массива - {SearchIndex(array)}");
        }

        static int SearchIndex(double[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                double sumLeft = 0, sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }

                for (int j = array.Length - 1; j > i; j--)
                {
                    sumRight += array[j];
                }

                if (sumLeft == sumRight) return i;
            }

            return -1;
        }
    }
}
