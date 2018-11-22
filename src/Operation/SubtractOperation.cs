using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class SubtractOperation : Operation
    {
        public static readonly OperationInfo Info = new OperationInfo("subtract", '-');

        public override bool Execute(RuntimeState state)
        {
            Variable value = state.Stack.PopLast();
            state.Stack.Last().Subtract(value);
            state.OperationIndex++;
            return true;
        }

        public override byte[] ToGolf() => new byte[] { (byte)Info.Symbol };
    }
}
