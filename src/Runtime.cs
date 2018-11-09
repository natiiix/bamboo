using System.Collections.Generic;

namespace Bamboo
{
    public sealed class Runtime
    {
        private List<Operation> Operations { get; }

        public Runtime(List<Operation> operations)
        {
            Operations = operations;
        }

        public void Run(params Variable[] args)
        {
            for (RuntimeState state = new RuntimeState(args); state.OperationIndex < Operations.Count && Operations[state.OperationIndex].Execute(state);) ;
        }
    }
}
