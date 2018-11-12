using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class DivideOperation : Operation
    {
        public const string Symbol = "/";
        public const string Name = "divide";

        public override bool Execute(RuntimeState state)
        {
            Variable value = state.Stack.PopLast();
            state.Stack.Last().Divide(value);
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() => Symbol;
    }
}
