using System;

namespace Bamboo
{
    public abstract class Variable : IGolfable
    {
        public static Variable Parse(string str)
        {
            if (int.TryParse(str, out int intValue))
            {
                return new IntegerVariable(intValue);
            }

            throw new ArgumentException(str);
        }

        public abstract override string ToString();

        public abstract string ToGolf();
    }
}
