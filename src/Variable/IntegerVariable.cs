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

        public override string ToString() =>
            Value.ToString();

        public override string ToGolf()
        {
            bool negative = Value < 0;
            string inBase = BaseConverter.ToBase(negative ? -Value : Value);
            return inBase.Length.ToString() + inBase + (negative ? NegateOperation.Info.Symbol.ToString() : string.Empty);
        }

        public override Variable Clone() =>
            new IntegerVariable(Value);

        public override void Negate() =>
            Value = -Value;

        private void PerformAirthmeticOperation(Variable value, Action<int> actionInt)
        {
            if (value is IntegerVariable intValue)
            {
                actionInt(intValue.Value);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override void Add(Variable value) =>
            PerformAirthmeticOperation(value, intValue => Value += intValue);

        public override void Subtract(Variable value) =>
            PerformAirthmeticOperation(value, intValue => Value -= intValue);

        public override void Multiply(Variable value) =>
            PerformAirthmeticOperation(value, intValue => Value *= intValue);

        public override void Divide(Variable value) =>
            PerformAirthmeticOperation(value, intValue => Value /= intValue);

        public override void Modulo(Variable value) =>
            PerformAirthmeticOperation(value, intValue => Value %= intValue);
    }
}
