namespace Solution.IZ04_04_ConcatenateString
{
    static public class String
    {
        static public string Concatenate(string strFirst, string strSecond)
        {
            int lengthFirstStr = strFirst.Length;
            int lengthSecondStr = strSecond.Length;

            int length = lengthFirstStr + lengthSecondStr;
            char[] newStr = new char[length];

            int i = 0;

            for (; i < lengthFirstStr; i++)
            {
                newStr[i] = strFirst[i];
            }

            for (int j = 0; j < lengthSecondStr; j++)
            {
                if (FindLetter(strFirst, strSecond[j]))
                {
                    newStr[i] = strSecond[j];
                    i++;
                }
            }

            return new string(newStr, 0, i);
        }

        static private bool FindLetter(string str, char letter)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (letter == str[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
