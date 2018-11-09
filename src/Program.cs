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
                new Runtime(ParseCommands(args[0])).Run(args.Skip(1).Select(x => Variable.Parse(x)).ToArray());
            }
        }

        private static List<Command> ParseCommands(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }

            List<Command> commands = new List<Command>();

            foreach (string line in File.ReadLines(filePath))
            {
                Command cmd = Command.Parse(line);

                if (cmd != null)
                {
                    commands.Add(cmd);
                }
            }

            return commands;
        }
    }
}
