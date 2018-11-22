namespace Bamboo
{
    public sealed class PushOperation : Operation
    {
        private Variable Value { get; }

        public PushOperation(Variable var)
        {
            Value = var;
        }

        public override bool Execute(RuntimeState state)
        {
            state.Stack.Add(Value);
            state.OperationIndex++;
            return true;
        }

        public override byte[] ToGolf() =>
            Value.ToGolf();
    }
}
