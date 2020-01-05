using System;

namespace Solution.IZ04_03_SumIndexElement
{
    static public class SumIndexElement
    {
        static public int Find(double[] array)
        {
            const double eps = 0.00001;

            double sumLeft = 0, sumRight = 0;
            

            for (int i = 1; i < array.Length - 1; i++, sumLeft = 0, sumRight= 0)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }

                for (int j = array.Length - 1; j > i; j--)
                {
                    sumRight += array[j];
                }

                if (Math.Abs(sumLeft - sumRight) < eps) return i;
            }
            return -1;
        }
    }
}
