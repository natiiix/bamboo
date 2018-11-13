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
            if (args.Length >= 2)
            {
                Variable[] runtimeArgs = args.Skip(2).Select(x => Variable.Parse(x)).ToArray();

                switch (args[0])
                {
                    case "-c":
                    case "--compile":
                        break;

                    case "-r":
                    case "--run":
                        new Runtime(Operation.ParseVerboseOperations(args[1])).Run(runtimeArgs);
                        break;

                    case "-g":
                    case "--golf":
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
