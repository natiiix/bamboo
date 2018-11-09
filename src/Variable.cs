using System;

namespace Bamboo
{
    public abstract class Variable
    {
        public static Variable Parse(string str)
        {
            if (int.TryParse(str, out int intValue))
            {
                return new IntegerVariable(intValue);
            }

            throw new ArgumentException(str);
        }
    }
}
