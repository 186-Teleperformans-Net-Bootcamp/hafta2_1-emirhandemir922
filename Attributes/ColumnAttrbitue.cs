namespace Teleperformance._2.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; }
        public string Type { get; }
        public bool Required { get; }

        public ColumnAttribute(string name, string type, bool required)
        {
            Name = name;
            Type = type;
            Required = required;
        }
    }
}
