using System.Collections.Generic;

namespace Bamboo
{
    public sealed class Runtime : IGolfable
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

        public string ToGolf()
        {
            string str = string.Empty;

            foreach (Operation op in Operations)
            {
                str += op.ToGolf();
            }

            return str;
        }
    }
}
