namespace Project_Edge.Core.Attribute
{
    public class DisplayNameAttribute : System.Attribute
    {
        public string Name { get; }
        public DisplayNameAttribute(string name) => Name = name;
    }

}