using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class ModuloOperation : Operation
    {
        public static readonly OperationInfo Info = new OperationInfo("modulo", '%');

        public override bool Execute(RuntimeState state)
        {
            Variable value = state.Stack.PopLast();
            state.Stack.Last().Modulo(value);
            state.OperationIndex++;
            return true;
        }

        public override byte[] ToGolf() => new byte[] { (byte)Info.Symbol };
    }
}
