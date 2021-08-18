namespace DataLibrary
{
    public class Service
    {
        public string DisplayName { get; set; }
        public string ServiceName { get; set; }
        public override string ToString() => $"{ServiceName}";
        public string[] ItemArray => new[] {DisplayName, ServiceName};
    }
}
