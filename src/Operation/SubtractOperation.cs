using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class SubtractOperation : Operation
    {
        public const string Symbol = "-";
        public const string Name = "subtract";

        public override bool Execute(RuntimeState state)
        {
            Variable value = state.Stack.PopLast();
            state.Stack.Last().Subtract(value);
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() => Symbol;
    }
}
