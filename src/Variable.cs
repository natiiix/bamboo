namespace Bamboo
{
    public abstract class Variable
    {
        public static bool TryParse(string str, out Variable value)
        {
            value = null;
            return false;
        }
    }
}
