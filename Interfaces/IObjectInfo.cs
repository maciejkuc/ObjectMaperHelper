namespace ObjectMaper.Interfaces
{
    internal interface IObjectInfo
    {
        string ClassName { get; set; }
        string Name { get; set; }
        string VisibleName { get; set; }
        string Description { get; set; }
        bool Ignore { get; set; }
        bool Optional { get; set; }
        System.Type Type { get; set; }
        IMapping Mapping { get; set; }
    }
}