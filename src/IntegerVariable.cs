using System;

namespace Bamboo
{
    public sealed class IntegerVariable : Variable
    {
        public int Value { get; private set; }

        public IntegerVariable(int value)
        {
            Value = value;
        }

        public override void Negate() =>
            Value = -Value;

        public override string ToString() =>
            Value.ToString();

        public override string ToGolf()
        {
            bool negative = Value < 0;
            string inBase = BaseConverter.ToBase(negative ? -Value : Value);
            return inBase.Length.ToString() + inBase + (negative ? NegateOperation.Symbol : string.Empty);
        }
    }
}
