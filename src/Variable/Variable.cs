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

        public abstract byte[] ToGolf();

        public abstract Variable Clone();
        public abstract void Negate();
        public abstract void Add(Variable value);
        public abstract void Subtract(Variable value);
        public abstract void Multiply(Variable value);
        public abstract void Divide(Variable value);
        public abstract void Modulo(Variable value);
    }
}
