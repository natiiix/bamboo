using System;

namespace Bamboo
{
    public sealed class IntegerVariable : Variable
    {
        public int Value { get; }

        public IntegerVariable(int value)
        {
            Value = value;
        }
    }
}
