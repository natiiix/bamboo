using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class NegateOperation : Operation
    {
        public static readonly OperationInfo Info = new OperationInfo("negate", '~');

        public override bool Execute(RuntimeState state)
        {
            state.Stack.Last().Negate();
            state.OperationIndex++;
            return true;
        }

        public override byte[] ToGolf() => new byte[] { (byte)Info.Symbol };
    }
}
