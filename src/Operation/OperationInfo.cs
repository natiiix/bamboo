namespace Bamboo
{
    public sealed class OperationInfo
    {
        public string Name { get; }
        public char Symbol { get; }

        public OperationInfo(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}
