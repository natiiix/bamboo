using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class NegateOperation : Operation
    {
        public const string Symbol = "~";
        public const string Name = "negate";

        public override bool Execute(RuntimeState state)
        {
            state.Stack.Last().Negate();
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() => Symbol;
    }
}
