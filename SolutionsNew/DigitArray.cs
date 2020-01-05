using System;

namespace Solution.IZ04_06_FilterDigit
{
    static public class DigitArray
    {
        static public int[] Filter(int[] array, int value)
        {
            int[] newArray = new int[array.Length];
            int length = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (HasANumber(Math.Abs(array[i]), value))
                {
                    newArray[length] = array[i];
                    length++;
                }
            }

            if (length == 0) return new int[] { };
            Array.Resize(ref newArray, length);

            return newArray;
        }

        static private bool HasANumber(int value, int wantedValue)
        {
            int length;
            int[] array = IntToArrayInt(value, out length);

            for (int i = 0; i < length; i++)
            {
                if (wantedValue == array[i])
                {
                    return true;
                }
            }

            return false;
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
    }
}
