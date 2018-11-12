using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class NegateOperation : Operation
    {
        public static string Symbol => "~";

        public override bool Execute(RuntimeState state)
        {
            throw new NotImplementedException();
        }

        public override string ToGolf() => Symbol;
    }
}
