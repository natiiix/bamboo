using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class MultiplyOperation : Operation
    {
        public const string Symbol = "*";
        public const string Name = "multiply";

        public override bool Execute(RuntimeState state)
        {
            Variable value = state.Stack.PopLast();
            state.Stack.Last().Multiply(value);
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() => Symbol;
    }
}
