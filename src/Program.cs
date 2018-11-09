using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Bamboo
{
    public sealed class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                new Runtime(ParseOperations(args[0])).Run(args.Skip(1).Select(x => Variable.Parse(x)).ToArray());
            }
        }

        private static List<Operation> ParseOperations(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }

            List<Operation> operations = new List<Operation>();

            foreach (string line in File.ReadLines(filePath))
            {
                Operation op = Operation.Parse(line);

                if (op != null)
                {
                    operations.Add(op);
                }
            }

            return operations;
        }
    }
}
