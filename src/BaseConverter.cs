using System;

namespace Bamboo
{
    public static class BaseConverter
    {
        private const char MIN_PRINTABLE_CHAR = ' ';
        private const char MAX_PRINTABLE_CHAR = '~';
        private const int BASE_VALUE = MAX_PRINTABLE_CHAR - MIN_PRINTABLE_CHAR;

        public static string ToBase(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(value.ToString());
            }

            string str = string.Empty;
            int remainder = value;

            while (remainder > 0)
            {
                int digitValue = remainder % BASE_VALUE;
                remainder /= BASE_VALUE;

                char digitChar = (char)(MIN_PRINTABLE_CHAR + digitValue);
                str += digitChar;
            }

            return str;
        }

        public static int FromBase(string str)
        {
            int value = 0;

            foreach (char c in str)
            {
                if (c < MIN_PRINTABLE_CHAR || c > MAX_PRINTABLE_CHAR)
                {
                    throw new ArgumentException(str);
                }

                int digitValue = c - MIN_PRINTABLE_CHAR;

                value *= BASE_VALUE;
                value += digitValue;
            }

            return value;
        }
    }
}
