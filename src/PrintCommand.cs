using System;
using System.Collections.Generic;
using System.Linq;

namespace Bamboo
{
    public sealed class PrintCommand : Command
    {
        public override bool Execute(RuntimeState state)
        {
            Console.WriteLine(state.Stack.Last());
            state.CommandIndex++;
            return true;
        }
    }
}
