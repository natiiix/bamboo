using System;

namespace Bamboo
{
    public abstract class Variable
    {
        public static Variable Parse(string str)
        {
            throw new ArgumentException(str);
        }
    }
}
