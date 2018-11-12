using System;
using System.Collections.Generic;

namespace Bamboo
{
    public abstract class Operation : IGolfable
    {
        public abstract bool Execute(RuntimeState state);

        public static Operation Parse(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            string lower = str.ToLower();

            switch (lower)
            {
                case PrintOperation.Name:
                    return new PrintOperation();

                case NegateOperation.Name:
                    return new NegateOperation();

                case AddOperation.Name:
                    return new AddOperation();

                case SubtractOperation.Name:
                    return new SubtractOperation();

                case MultiplyOperation.Name:
                    return new MultiplyOperation();

                case DivideOperation.Name:
                    return new DivideOperation();

                case ModuloOperation.Name:
                    return new ModuloOperation();

                default:
                    return new PushOperation(Variable.Parse(str));
            }
        }

        public abstract string ToGolf();
    }
}
