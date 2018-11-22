using System;
using System.Collections.Generic;
using System.Linq;
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

        public static List<Operation> ParseGolfedOperations(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }

            byte[] code = File.ReadAllBytes(filePath);

            List<Operation> operations = new List<Operation>();

            for (int i = 0; i < code.Length; i++)
            {
                byte b = code[i];
                char c = (char)b;

                if (char.IsDigit(c))
                {
                    int len = int.Parse(c.ToString());
                    byte[] sub = new byte[sizeof(int)];

                    for (int j = 0; j < len; j++)
                    {
                        sub[j] = code[i + 1 + j];
                    }

                    for (int j = len; j < sub.Length; j++)
                    {
                        sub[j] = 0;
                    }

                    int value = BitConverter.ToInt32(sub);
                    operations.Add(new PushOperation(new IntegerVariable(value)));

                    i += len;
                }
                else
                {
                    operations.Add(ParseGolfed(c));
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

        private static Operation ParseGolfed(char c)
        {
            if (c == PrintOperation.Info.Symbol) return new PrintOperation();
            else if (c == CloneOperation.Info.Symbol) return new CloneOperation();
            else if (c == NegateOperation.Info.Symbol) return new NegateOperation();
            else if (c == AddOperation.Info.Symbol) return new AddOperation();
            else if (c == SubtractOperation.Info.Symbol) return new SubtractOperation();
            else if (c == MultiplyOperation.Info.Symbol) return new MultiplyOperation();
            else if (c == DivideOperation.Info.Symbol) return new DivideOperation();
            else if (c == ModuloOperation.Info.Symbol) return new ModuloOperation();

            throw new ArgumentException(c.ToString());
        }

        public abstract byte[] ToGolf();
    }
}
