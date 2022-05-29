namespace Teleperformance._2.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string UnwantedChars { get; }
        public TableAttribute(string unwantedChars)
        {
            UnwantedChars = unwantedChars;
        }
    }
}
