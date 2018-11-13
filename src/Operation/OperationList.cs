using System.Collections.Generic;

namespace Bamboo
{
    public static class OperationList
    {
        public static readonly Dictionary<Operations, OperationInfo> Info = new Dictionary<Operations, OperationInfo>()
        {
            { Operations.Print, PrintOperation.Info },
            { Operations.Clone, CloneOperation.Info },
            { Operations.Negate, NegateOperation.Info },
            { Operations.Add, AddOperation.Info },
            { Operations.Subtract, SubtractOperation.Info },
            { Operations.Multiply, MultiplyOperation.Info },
            { Operations.Divide, DivideOperation.Info },
            { Operations.Modulo, ModuloOperation.Info },
        };
    }
}
