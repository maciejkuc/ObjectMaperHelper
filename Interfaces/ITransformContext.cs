namespace ObjectMappingHelper.Interfaces
{
    public interface ITransformContext
    {
        IObjectProvider ObjectProvider { get; set; }
        IReader Reader { get; set; }
        iMaper Maper { get; set; }
        IParser Parser { get; set; }
        IWriter Writer { get; set; }
        IConfiguration configuration { get; set; }

    }
}