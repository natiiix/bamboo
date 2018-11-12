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
                case "print":
                    return new PrintOperation();

                default:
                    return new PushOperation(Variable.Parse(str));
            }
        }

        public abstract string ToGolf();
    }
}
