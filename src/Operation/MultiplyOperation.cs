using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class MultiplyOperation : Operation
    {
        public static readonly OperationInfo Info = new OperationInfo("multiply", '*');

        public override bool Execute(RuntimeState state)
        {
            Variable value = state.Stack.PopLast();
            state.Stack.Last().Multiply(value);
            state.OperationIndex++;
            return true;
        }

        public override byte[] ToGolf() => new byte[] { (byte)Info.Symbol };
    }
}
