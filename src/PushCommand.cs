namespace Bamboo
{
    public sealed class PushCommand : Command
    {
        private Variable Value { get; }

        public PushCommand(Variable var)
        {
            Value = var;
        }

        public override bool Execute(RuntimeState state)
        {
            state.Stack.Add(Value);
            state.CommandIndex++;
            return true;
        }
    }
}
