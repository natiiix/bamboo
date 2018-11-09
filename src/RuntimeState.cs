using System.Collections.Generic;

namespace Bamboo
{
    public sealed class RuntimeState
    {
        public List<Variable> Stack { get; private set; }
        public int OperationIndex { get; set; }

        public RuntimeState(params Variable[] args)
        {
            Reset(args);
        }

        public void Reset(params Variable[] args)
        {
            Stack = new List<Variable>(args);
            OperationIndex = 0;
        }
    }
}
