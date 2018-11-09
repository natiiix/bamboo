using System.Collections.Generic;

namespace Bamboo
{
    public sealed class Runtime
    {
        private List<Command> Commands { get; }

        public Runtime(List<Command> commands)
        {
            Commands = commands;
        }

        public void Run(params Variable[] args)
        {
            for (RuntimeState state = new RuntimeState(args); state.CommandIndex < Commands.Count && Commands[state.CommandIndex].Execute(state);) ;
        }
    }
}
