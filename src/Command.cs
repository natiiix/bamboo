using System;
using System.Collections.Generic;

namespace Bamboo
{
    public abstract class Command
    {
        public abstract bool Execute(RuntimeState state);

        public static Command Parse(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            string lower = str.ToLower();

            switch (lower)
            {
                case "print":
                    return new PrintCommand();

                default:
                    return new PushCommand(Variable.Parse(str));
            }
        }
    }
}
