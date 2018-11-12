using System.Linq;

namespace Bamboo
{
    public sealed class CloneOperation : Operation
    {
        private Variable Value { get; }

        public CloneOperation(Variable var)
        {
            Value = var;
        }

        public override bool Execute(RuntimeState state)
        {
            Variable clone = state.Stack.Last().Clone();
            state.Stack.Add(clone);
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() =>
            Value.ToGolf();
    }
}
