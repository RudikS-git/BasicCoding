using System;

namespace Solution.IZ04_05_FindNextBiggerNumber
{
    static public class NextBiggerNumber
    {
        static public int Find(int value)
        {
            if (value < 0) throw new ArgumentException("Value must be positive");
            else if (value < 11) return -1;

            int length;
            int[] array = IntToArrayInt(value, out length);

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    SwapValues(ref array[i], ref array[i + 1]);
                    Array.Sort(array, 0, i + 1);
                    Array.Reverse(array, 0, i + 1);
                    break;
                }

            }

            int newValue = ArrayIntToInt(array);
            if (value == newValue)
            {
                return -1;
            }
            else return newValue;
        }

        static private int[] IntToArrayInt(int value, out int length)
        {
            length = value.ToString().Length;
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = value % 10;
                value /= 10;
            }

            return array;
        }

        static private int ArrayIntToInt(int[] array)
        {
            int value = 0;
            for (int i = 0, discharge = 1; i < array.Length; i++, discharge *= 10)
            {
                value += array[i] * discharge;
            }

            return value;
        }

        static private void SwapValues(ref int valueFirst, ref int valueSecond)
        {
            int temp = valueFirst;
            valueFirst = valueSecond;
            valueSecond = temp;
        }
    }
}
