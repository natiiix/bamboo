using System;
using System.Collections.Generic;
using System.IO;

namespace Bamboo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 1)
            {

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
