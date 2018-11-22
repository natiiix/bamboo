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
            if (args.Length <= 0)
            {
                return;
            }

            switch (args[0])
            {
                case "-c":
                case "--compile":
                    if (args.Length >= 3)
                    {
                        File.WriteAllBytes(args[2], new Runtime(Operation.ParseVerboseOperations(args[1])).ToGolf());
                    }
                    break;

                case "-r":
                case "--run":
                    if (args.Length >= 2)
                    {
                        new Runtime(Operation.ParseVerboseOperations(args[1])).Run(args.Skip(2).Select(x => Variable.Parse(x)).ToArray());
                    }
                    break;

                case "-g":
                case "--golf":
                    if (args.Length >= 2)
                    {
                        new Runtime(Operation.ParseGolfedOperations(args[1])).Run(args.Skip(2).Select(x => Variable.Parse(x)).ToArray());
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
