namespace ObjectMappingHelper
{
    public interface IParserConfiguration
    {
        int FileHeaderLineCount { get; set; }
        int FileTailLineCount { get; set; }
    }
}