using System;
using System.Collections.Generic;
using System.IO;

namespace Bamboo
{
    public abstract class Operation : IGolfable
    {
        public abstract bool Execute(RuntimeState state);

        public static List<Operation> ParseVerboseOperations(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }

            List<Operation> operations = new List<Operation>();

            foreach (string line in File.ReadLines(filePath))
            {
                Operation op = Operation.ParseVerbose(line);

                if (op != null)
                {
                    operations.Add(op);
                }
            }

            return operations;
        }

        private static Operation ParseVerbose(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            string lower = str.ToLower();

            if (lower == PrintOperation.Info.Name) return new PrintOperation();
            else if (lower == CloneOperation.Info.Name) return new CloneOperation();
            else if (lower == NegateOperation.Info.Name) return new NegateOperation();
            else if (lower == AddOperation.Info.Name) return new AddOperation();
            else if (lower == SubtractOperation.Info.Name) return new SubtractOperation();
            else if (lower == MultiplyOperation.Info.Name) return new MultiplyOperation();
            else if (lower == DivideOperation.Info.Name) return new DivideOperation();
            else if (lower == ModuloOperation.Info.Name) return new ModuloOperation();
            else return new PushOperation(Variable.Parse(str));
        }

        public abstract string ToGolf();
    }
}
