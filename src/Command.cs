namespace Bamboo
{
    public abstract class Command
    {
        public static Command Parse(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            string lower = str.ToLower();

            switch (lower)
            {
                default:
                    break;
            }

            return null;
        }
    }
}
