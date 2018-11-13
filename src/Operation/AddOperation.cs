using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class AddOperation : Operation
    {
        public static readonly OperationInfo Info = new OperationInfo("add", '+');

        public override bool Execute(RuntimeState state)
        {
            Variable value = state.Stack.PopLast();
            state.Stack.Last().Add(value);
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() => Info.Symbol.ToString();
    }
}
