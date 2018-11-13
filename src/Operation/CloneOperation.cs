using System.Linq;

namespace Bamboo
{
    public sealed class CloneOperation : Operation
    {
        public static readonly OperationInfo Info = new OperationInfo("clone", '$');

        public override bool Execute(RuntimeState state)
        {
            Variable clone = state.Stack.Last().Clone();
            state.Stack.Add(clone);
            state.OperationIndex++;
            return true;
        }

        public override string ToGolf() => Info.Symbol.ToString();
    }
}
