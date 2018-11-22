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

        public byte[] ToGolf()
        {
            List<byte> bytes = new List<byte>();

            foreach (Operation op in Operations)
            {
                bytes.AddRange(op.ToGolf());
            }

            return bytes.ToArray();
        }
    }
}
