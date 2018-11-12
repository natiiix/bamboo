using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class PrintOperation : Operation
    {
        public static string Symbol => "p";

        public override bool Execute(RuntimeState state)
        {
            Console.WriteLine(state.Stack.Last());
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() => Symbol;
    }
}
